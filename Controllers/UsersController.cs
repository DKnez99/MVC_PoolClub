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
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> logger;
        private readonly IAppUserService appUserService;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UsersController(ILogger<UsersController> logger, IAppUserService appUserService, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.logger = logger;
            this.appUserService = appUserService;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [Authorize(Roles ="Staff")]
        public IActionResult Index()
        {
            var model = appUserService.GetAllAppUsers();
            return View(model);
        }

        [Authorize(Roles = "Staff")]
        public async Task<IActionResult> Details(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", id);
            }
            else
            {
                var roles = await userManager.GetRolesAsync(user);
                UsersDetailsViewModel model = new UsersDetailsViewModel()
                {
                    AppUser = user,
                    Roles = roles
                };
                return View(model);
            }       
        }
    }
}
