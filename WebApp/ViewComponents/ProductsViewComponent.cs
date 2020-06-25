using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;
using WebApp.ViewModels;

namespace WebApp.ViewComponents
{
    public class ProductsViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public ProductsViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? page) 
        {
            var model = _db.Products.Select(p => new ProductVM
            {
                Id = p.Id,
                Price = p.Price,
                Image = p.Image,
                Title = p.Title,
                Category = p.Category
            }).Take(8);

            if (page != null)
            {
                model = _db.Products.Select(p => new ProductVM
                {
                    Id = p.Id,
                    Price = p.Price,
                    Image = p.Image,
                    Title = p.Title,
                    Category = p.Category
                }).Skip((int)(page - 1) * 8).Take(8);
            }


            return View(await Task.FromResult(model));
        }
    }
}
