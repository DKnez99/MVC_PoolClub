using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PoolClub.Models;
using PoolClub.Models.Services;
using PoolClub.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PoolClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IAppUserService appUserService;
        public HomeController(ILogger<HomeController> logger, IAppUserService appUserService)
        {
            this.logger = logger;
            this.appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(HomeRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                AppUser newAppUser = appUserService.AddAppUser(new AppUser()
                {
                    Email = model.Email,
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    PhoneNumber = model.PhoneNumber,
                    RoleId = 2  //Visitor role
                });

                //return RedirectToAction("Details", "Users", new { id = newAppUser.Id });
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(model);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
