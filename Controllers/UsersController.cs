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
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> logger;
        private readonly IAppUserService appUserService;

        public UsersController(ILogger<UsersController> logger, IAppUserService appUserService)
        {
            this.logger = logger;
            this.appUserService = appUserService;
        }
        public IActionResult Index()
        {
            var model = appUserService.GetAllAppUsers();
            return View(model);
        }
        public IActionResult Details(int id)
        {
            UsersDetailsViewModel model = new UsersDetailsViewModel()
            {
                AppUser = appUserService.GetAppUser(id),
                PageTitle = "User Details"
            };
            return View(model);
        }
    }
}
