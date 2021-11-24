using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<TablesController> logger;
        private readonly ITableService tableService;
        private readonly UserManager<AppUser> userManager;

        public TablesController(ILogger<TablesController> logger, ITableService tableService, UserManager<AppUser> userManager)
        {
            this.logger = logger;
            this.tableService = tableService;
            this.userManager = userManager;
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
            TablesReservationViewModel model = new TablesReservationViewModel()
            {
                TableId = table.TableId,
                UserEmail = User.Identity.Name,
                Date = System.DateTime.Now.Date,
                TimeFrom = System.DateTime.Now,
                TimeTo=System.DateTime.Now.AddHours(1)
            };
            return View(model);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Reserve(TablesReservationViewModel model)
        {
            if (ModelState.IsValid)
            {
                var userEmail=model.UserEmail;
                Table table = tableService.GetTable(id);
                if (table == null)
                {
                    Response.StatusCode = 404;
                    return View("TableNotFound", id);
                }
                TablesReservationViewModel model = new TablesReservationViewModel()
                {
                    TableId = table.TableId,
                    UserEmail = User.Identity.Name,
                    Date = System.DateTime.Now.Date,
                    TimeFrom = System.DateTime.Now,
                    TimeTo = System.DateTime.Now.AddHours(1)
                };
                return View(model);
            }
            
        }
    }
}
