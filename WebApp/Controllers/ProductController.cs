using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.DAL;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;

        public ProductController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int? page)
        {
            if (page == null)
            {
                ViewBag.pageIndicator = 1;
            }
            else
            {
                ViewBag.pageIndicator = page;
            }
            ViewBag.Page = Math.Ceiling((decimal)(_db.Products.Count()) / 8);
            ViewBag.Count = _db.Products.Count();
            if (page == null)
            {
                return View(_db.Products.Select(p => new ProductVM
                {
                    Id = p.Id,
                    Price = p.Price,
                    Image = p.Image,
                    Title = p.Title,
                    Category = p.Category
                }).Take(8));
            }
            else {
                return View(_db.Products.Select(p => new ProductVM
                {
                    Id = p.Id,
                    Price = p.Price,
                    Image = p.Image,
                    Title = p.Title,
                    Category = p.Category
                }).Skip((int)(page-1) * 8).Take(8));
            }
        }

        

        //public IActionResult Load(int skip)
        //{
        //    var model = _db.Products.Select(p => new ProductVM
        //    {
        //        Id = p.Id,
        //        Price = p.Price,
        //        Image = p.Image,
        //        Title = p.Title,
        //        Category = p.Category
        //    }).Skip(skip).Take(8);

        //    return PartialView("_ProductPartial", model);
        //}
    }
}