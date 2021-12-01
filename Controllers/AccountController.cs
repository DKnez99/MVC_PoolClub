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
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> logger;
        private readonly IAppUserService appUserService;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AccountController(ILogger<AccountController> logger, IAppUserService appUserService,
                                UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,
                                RoleManager<IdentityRole> roleManager)
        {
            this.logger = logger;
            this.appUserService = appUserService;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName=model.Email,
                    Email = model.Email,
                    PhoneNumber=model.PhoneNumber,
                    LastName=model.LastName,
                    FirstName=model.FirstName,
                    EmailConfirmed=true,
                    LockoutEnabled=false,
                    PhoneNumberConfirmed=true
                };

                var result = await userManager.CreateAsync(user, model.Password);       //create new user in database with hashed password

                if (result.Succeeded)
                {
                    //await signInManager.SignInAsync(user, isPersistent:false); //if we want to automatically log in after registering
                    var newlyCreatedUser = await userManager.FindByNameAsync(model.Email);
                    await userManager.AddToRoleAsync(newlyCreatedUser, "Visitor");      //automatically add new users to visitors
                    TempData["SuccessMsg"] = "New account created. Now you can log in.";
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {

                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password,
                                                    model.IsPersistent, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))           //check if we were redirected
                        return LocalRedirect(returnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Unable to sign in.");
            }
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> MyAccount()
        {
            AppUser appUser = await userManager.FindByNameAsync(User.Identity.Name);    //find user by username (email in our case)
            return View(appUser);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> EditAccount(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", id);
            }
            if (User.Identity.Name != user.Email)
            {
                return View("AccessDenied");
            }
            
            AccountEditViewModel model = new AccountEditViewModel()
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditAccount(AccountEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                Response.StatusCode = 404;
                return View("UserNotFound", model.Id);
            }
            String password = model.Password;
            var hasher = new PasswordHasher<AppUser>();
            if (hasher.VerifyHashedPassword(user, user.PasswordHash, model.Password)== PasswordVerificationResult.Failed) //compare DB password with entered old password
            {
                ModelState.AddModelError("", "Password is incorrect.");
                return View(model);
            }
            if (model.NewPassword!=null) //if user entered new password
            {
                password = model.NewPassword;
                await signInManager.SignOutAsync(); //check
            }

            if (user.Email != model.Email)
            {
                await signInManager.SignOutAsync(); //check
            }

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.PasswordHash = hasher.HashPassword(user, password);
            user.UserName = model.Email;
            user.NormalizedUserName = model.Email.ToUpper();
            user.Email = model.Email;
            user.NormalizedEmail = model.Email.ToUpper();
            user.PhoneNumber = model.PhoneNumber;

            var result = await userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                TempData["SuccessMsg"] = "Changes saved.";
                return RedirectToAction("Index", "Home");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View(model);
        }
    }
}
