using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PoolClub.Hubs;
using PoolClub.Models;
using PoolClub.Models.Services;
using PoolClub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Controllers
{
    [Authorize]
    public class TablesController : Controller
    {
        private readonly IHubContext<ReservationHub> hubContext;
        private readonly ILogger<TablesController> logger;
        private readonly ITableService tableService;
        private readonly UserManager<AppUser> userManager;

        public TablesController(ILogger<TablesController> logger, ITableService tableService, UserManager<AppUser> userManager, IHubContext<ReservationHub> hubContext)
        {
            this.logger = logger;
            this.tableService = tableService;
            this.userManager = userManager;
            this.hubContext = hubContext;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = tableService.GetAllTables();
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Reserve(int id)
        {
            Table table = tableService.GetTable(id);
            if (table == null)
            {
                Response.StatusCode = 404;
                return View("TableNotFound", id);
            }
            var time = System.DateTime.MinValue.AddHours(System.DateTime.Now.Hour+1);   //on page load set timeFrom to next full hour

            TablesReservationViewModel model = new TablesReservationViewModel()
            {
                TableId = table.TableId,
                UserEmail = User.Identity.Name,
                Date = System.DateTime.Now.Date,
                TimeFrom = time,
                TimeTo=time.AddHours(1)
            };
            return View(model);
        }

        private bool ValidateDates(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            if (DateTime.Compare(end1, start2) <= 0 || DateTime.Compare(start1, end2) >= 0) //if date1 is before or after date2
                return true;
            else
                return false;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Reserve(TablesReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.UserEmail);
                DateTime timeFrom = model.Date.AddHours(model.TimeFrom.Hour);
                DateTime timeTo = model.Date.AddHours((model.TimeTo.Hour==0)?24:model.TimeTo.Hour); //12AM goes to database as 00:00 the next day
                if (timeFrom<timeTo && timeFrom>DateTime.Now)
                {
                    var reservations = tableService.GetAllReservationsByTableAfterDate(model.TableId, model.Date);
                    bool alreadyReserved = false;
                    int alreadyReservedStart = 0, alreadyReservedEnd = 0;
                    foreach(var res in reservations)
                    {
                        //compare to *all* future reservations
                        if(!ValidateDates(timeFrom, timeTo, res.TimeFrom, res.TimeTo))
                        {
                            alreadyReserved = true;
                            alreadyReservedStart = res.TimeFrom.Hour;
                            alreadyReservedEnd=res.TimeTo.Hour;
                            break;
                        }
                    }

                    if (!alreadyReserved)   //if there are no overlapping reservations
                    {
                        Reservation newRes = new Reservation()
                        {
                            TableId = model.TableId,
                            UserId = user.Id,
                            TimeFrom = timeFrom,
                            TimeTo = timeTo
                        };

                        var myReservation = tableService.AddReservation(newRes);
                        if (myReservation != null)
                        {

                            //send through hub
                            await hubContext.Clients.All.SendAsync("ReceiveReservation", new object[] {
                                    myReservation.ReservationId,
                                    model.UserEmail,
                                    user.PhoneNumber,
                                    myReservation.TableId,
                                    model.Date.ToShortDateString(),
                                    model.TimeFrom.Hour + ":00",
                                    (model.TimeTo.Hour == 0) ? "24:00" : model.TimeTo.Hour + ":00",   //display 12AM as 24:00 of the same day
                                    false
                                });

                            TempData["SuccessMsg"] = "You reserved table " + model.TableId + " successfuly.";
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else        //if wanted reservation time overlaps with another reservation
                    {
                        ModelState.AddModelError("", "Another reservation already exists from "+alreadyReservedStart+":00 to "+alreadyReservedEnd+":00 on "+model.Date.ToShortDateString());
                    }
                }
                else            //if time from and time to are not valid
                {
                    ModelState.AddModelError("", "We don't serve time travelers.");
                }
                ModelState.AddModelError("", "Unable to make a reservation.");
            }
            return View(model);
        }
    }
}
