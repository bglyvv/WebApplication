using Microsoft.AspNetCore.Internal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.DAL;

namespace WebApp.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync() {

            Models.Data data = _db.Data.FirstOrDefault();

            return View(await Task.FromResult(data));
        
        }
    }
}
