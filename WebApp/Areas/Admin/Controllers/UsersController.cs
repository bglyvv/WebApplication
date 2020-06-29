using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class UsersController : Controller
    {

        private readonly UserManager<User> _userManager;
        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<User> users = _userManager.Users.ToList();
            List<UserVM> usersVM = new List<UserVM>();

            foreach (var user in users) {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                usersVM.Add(userVM);
            }
            return View(usersVM);
        }

        public async Task<IActionResult> Detail(string id) {
            if (id == null) return NotFound();
            User user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();


            UserVM userVM = new UserVM
            {
                Id = user.Id,
                Fullname = user.Fullname,
                Username = user.UserName,
                Email = user.Email,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View (userVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(string id,UserVM userVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (id == null) return NotFound();
            User user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            string oldRole = (await _userManager.GetRolesAsync(user))[0];
            string newRole = Request.Form["roles"].ToString();
            await _userManager.RemoveFromRoleAsync(user,oldRole);
            await _userManager.AddToRoleAsync(user, newRole);

            return RedirectToAction("Index", "Users");
        }
    }
}
