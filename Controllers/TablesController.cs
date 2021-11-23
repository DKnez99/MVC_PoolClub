using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoolClub.Models.Services;
using PoolClub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Controllers
{
    public class TablesController : Controller
    {
        private readonly ILogger<TablesController> logger;
        private readonly ITableService tableService;

        public TablesController(ILogger<TablesController> logger, ITableService tableService)
        {
            this.logger = logger;
            this.tableService = tableService;
        }
        public IActionResult Index()
        {
            var model = tableService.GetAllTables();
            return View(model);
        }

        [HttpGet]
        public IActionResult Reserve(int id)
        {
            TablesReservationViewModel model = new TablesReservationViewModel()
            {
                TableId = id,
                UserId = 6,
                Date = System.DateTime.Now.Date,
                TimeFrom = System.DateTime.Now,
                TimeTo=System.DateTime.Now.AddHours(1)
            };
            return View(model);
        }
    }
}
