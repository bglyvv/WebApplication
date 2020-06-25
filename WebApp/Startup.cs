using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.DAL;

namespace WebApp
{
    public class Startup
    {

        private readonly IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            services.AddDbContext<AppDbContext>(options => {
                options.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute( name: "areas",template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            });
            app.UseMvc(routes => {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{ID?}");
            });
        }
    }
}
