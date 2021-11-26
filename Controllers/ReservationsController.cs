using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
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
    public class ReservationsController : Controller
    {
        private readonly IHubContext<ReservationHub> hubContext;
        private readonly ILogger<ReservationsController> logger;
        private readonly ITableService tableService;
        private readonly UserManager<AppUser> userManager;

        public ReservationsController(ILogger<ReservationsController> logger, ITableService tableService, UserManager<AppUser> userManager, IHubContext<ReservationHub> hubContext)
        {
            this.logger = logger;
            this.tableService = tableService;
            this.userManager = userManager;
            this.hubContext = hubContext;
        }

        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Index()
        {
            var reservations = tableService.GetAllReservations();
            List<ReservationViewModel> model = new List<ReservationViewModel>();
            foreach(var res in reservations)                                            //send all reservations as a list of ReservationViewModel to Index View
            {
                var user = await userManager.FindByIdAsync(res.UserId);
                bool exp = res.TimeTo <= DateTime.Now;
                string date = res.TimeFrom.Date.ToShortDateString();
                string timeFrom = res.TimeFrom.Hour + ":00";
                string timeTo = (res.TimeTo.Hour==0)?"24:00":res.TimeTo.Hour + ":00";
                ReservationViewModel resViewModel = new ReservationViewModel()
                {
                    ReservationId=res.ReservationId,
                    Email = user.Email,
                    PhoneNumber=user.PhoneNumber,
                    TableId = res.TableId,
                    Date = date,
                    TimeFrom = timeFrom,
                    TimeTo = timeTo,
                    Expired=exp
                };
                model.Add(resViewModel);
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyReservations()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var reservations = tableService.GetAllReservationsByUserId(user.Id);
            List<ReservationViewModel> model = new List<ReservationViewModel>();
            foreach (var res in reservations)
            {
                bool exp = res.TimeTo <= DateTime.Now;
                string date = res.TimeFrom.Date.ToShortDateString();
                string timeFrom = res.TimeFrom.Hour + ":00";
                string timeTo = (res.TimeTo.Hour == 0) ? "24:00" : res.TimeTo.Hour + ":00";
                ReservationViewModel resViewModel = new ReservationViewModel()
                {
                    ReservationId = res.ReservationId,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    TableId = res.TableId,
                    Date = date,
                    TimeFrom = timeFrom,
                    TimeTo = timeTo,
                    Expired = exp
                };
                model.Add(resViewModel);
            }
            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> MyReservations(int id)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            var deletedRes = tableService.DeleteReservation(id);

            var reservations = tableService.GetAllReservationsByUserId(user.Id);
            List<ReservationViewModel> model = new List<ReservationViewModel>();
            foreach (var res in reservations)
            {
                bool exp = res.TimeTo <= DateTime.Now;
                string date = res.TimeFrom.Date.ToShortDateString();
                string timeFrom = res.TimeFrom.Hour + ":00";
                string timeTo = (res.TimeTo.Hour == 0) ? "24:00" : res.TimeTo.Hour + ":00";
                ReservationViewModel resViewModel = new ReservationViewModel()
                {
                    ReservationId = res.ReservationId,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    TableId = res.TableId,
                    Date = date,
                    TimeFrom = timeFrom,
                    TimeTo = timeTo,
                    Expired = exp
                };
                model.Add(resViewModel);
            }
            if (deletedRes == null)
                TempData["Error"] = "Error. Cannot delete the reservation.";
            else
            {
                await hubContext.Clients.All.SendAsync("DeleteReservation", deletedRes.ReservationId);

                TempData["Success"] = "You successfuly deleted a reservation.";
            }

            return View(model);
        }


        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Details(int id)
        {
            Reservation res = tableService.GetReservation(id);  
            if (res == null)
            {
                Response.StatusCode = 404;
                return View("ReservationNotFound", id);
            }
            var user = await userManager.FindByIdAsync(res.UserId);
            ReservationsDetailsViewModel model = new ReservationsDetailsViewModel()
            {
                ReservationId = id,
                UserEmail = user.Email,
                TableId = res.TableId,
                Date = res.TimeFrom.Date.ToShortDateString(),
                TimeFrom = res.TimeFrom.Hour + ":00",
                TimeTo = (res.TimeTo.Hour == 0) ? "24:00" : res.TimeTo.Hour + ":00",
                UserFullName = user.FirstName + " " + user.LastName,
                PhoneNumber = user.PhoneNumber
            };
            return View(model);
        }
    }
}
