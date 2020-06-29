using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            User user = new User
            {
                Fullname = register.Fullname,
                UserName = register.Username,
                Email = register.Email
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(user, Helper.Roles.Member.ToString());
            await _signInManager.SignInAsync(user, true);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }

        public IActionResult Login() {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);
            User active_user = await _userManager.FindByEmailAsync(login.Email);
            if (active_user == null) { 
                ModelState.AddModelError(string.Empty, "Email or Passwrod are wrong!!!");
                return View(login);
            }
            var signInResult = await _signInManager.PasswordSignInAsync(active_user,login.Password,false,true);

            if (!signInResult.Succeeded) {
                ModelState.AddModelError(string.Empty, "Email or Passwrod are wrong!!!");
                return View(login);
            }
            return RedirectToAction("Index", "Home");
        }

        public async Task CreateRole() {

            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Admin.ToString())) 
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Admin.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Moderator.ToString())) 
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Moderator.ToString()));
            }

            if (!await _roleManager.RoleExistsAsync(Helper.Roles.Member.ToString())) 
            {
                await _roleManager.CreateAsync(new IdentityRole(Helper.Roles.Member.ToString()));
            }
            

        }

    }
}
