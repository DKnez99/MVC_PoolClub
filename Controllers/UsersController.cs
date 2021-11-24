using Microsoft.AspNetCore.Authorization;
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
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> logger;
        private readonly IAppUserService appUserService;

        public UsersController(ILogger<UsersController> logger, IAppUserService appUserService)
        {
            this.logger = logger;
            this.appUserService = appUserService;
        }

        [Authorize(Roles ="Staff")]
        public IActionResult Index()
        {
            var model = appUserService.GetAllAppUsers();
            return View(model);
        }

        [Authorize(Roles = "Staff")]
        public IActionResult Details(string id)
        {
            AppUser appUser = appUserService.GetAppUser(id);
            if (appUser == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", id);
            }
            return View(appUser);
        }
    }
}
