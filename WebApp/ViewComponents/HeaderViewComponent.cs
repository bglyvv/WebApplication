using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;
using WebApp.Migrations;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<User> _usermanager;
        public HeaderViewComponent(AppDbContext db, UserManager<User> usermanager)
        {
            _db = db;
            _usermanager = usermanager;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            string existing_basket = Request.Cookies["basket"];
            ViewBag.BasketCount = 0;
            ViewBag.BasketTotal = 0;
            if (User.Identity.IsAuthenticated) {
                User loginUser = await _usermanager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserFullname = loginUser.Fullname;
            }
            if (existing_basket != null)
            {
                List<ProductBasketVM> basket = JsonConvert.DeserializeObject<List<ProductBasketVM>>(existing_basket);
                ViewBag.BasketCount = basket.Sum(p=>p.Count);

                foreach (ProductBasketVM product in basket)
                {
                    ViewBag.BasketTotal += product.Price * product.Count;
                }

            }
            Models.Data data = _db.Data.FirstOrDefault();
            return View(await Task.FromResult(data));
            
        }
    }
}
