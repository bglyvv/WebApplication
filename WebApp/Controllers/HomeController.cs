using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.DAL;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = _db.Sliders,
                Products = _db.Products.Take(8),
                Categories = _db.Categories,
                AboutVideo = _db.AboutVideos.FirstOrDefault(),
                VideoContents = _db.VideoContents,
                AboutExpert = _db.AboutExperts.FirstOrDefault(),
                Experts = _db.Experts,
                AboutBlog = _db.AboutBlogs.FirstOrDefault(),
                Blogs = _db.Blogs,
                Owls = _db.Owls
            };
            return View(model);
        }

        public async Task<IActionResult> AddBasket(int? id) {
            if (id == null) return NotFound();
            Product product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();

            List<ProductBasketVM> products;
            string existing_basket = Request.Cookies["basket"];
            if (existing_basket == null)
            {
                products = new List<ProductBasketVM>();
            }
            else 
            {
                products = JsonConvert.DeserializeObject<List<ProductBasketVM>>(existing_basket);
            }

            ProductBasketVM checking_product = products.FirstOrDefault(p => p.Id == id);
            if (checking_product == null)
            {
                ProductBasketVM new_product = new ProductBasketVM
                {
                    Id = product.Id,
                    Image = product.Image,
                    Title = product.Title,
                    Price = product.Price,
                    Count = 1

                };
                products.Add(new_product);
            }
            else 
            {
                checking_product.Count++;
            }

            
            string basket = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });
            return RedirectToAction(nameof(Index));
            
        }
        //public IActionResult Basket() {

        //    return Content(Request.Cookies["basket"]);

        //}

        public IActionResult Json() {
            
            //List<ProductBasketVM> list = JsonConvert.DeserializeObject<List<ProductBasketVM>>(Request.Cookies["basket"]);

            //IQueryable<ProductBasketVM> model = (IQueryable<ProductBasketVM>)list.Select(p => new ProductBasketVM
            //{
            //    Id = p.Id,
            //    Image = p.Image,
            //    Title = p.Title,
            //    Price = p.Price,
            //    Count = p.Count
            //});
            return Json(Request.Cookies["basket"]);
            
            
            
            
        }

        public IActionResult DeleteBasket(int? id) {
            List<ProductBasketVM> list = JsonConvert.DeserializeObject<List<ProductBasketVM>>(Request.Cookies["basket"]);
            if (id == null) return NotFound();
            if (list.Find(p => p.Id == id) == null) return NotFound();

            list.Remove(list.FirstOrDefault(p => p.Id == id));
            if (list.Count == 0) { HttpContext.Response.Cookies.Delete("basket"); }
            string basket = JsonConvert.SerializeObject(list);
            Response.Cookies.Append("basket", basket, new CookieOptions { MaxAge = TimeSpan.FromDays(14) });

            return RedirectToAction(nameof(Index));
        }
    }
}