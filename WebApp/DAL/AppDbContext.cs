using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.DAL
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AboutVideo> AboutVideos { get; set; }
        public DbSet<VideoContent> VideoContents { get; set; }
        public DbSet<AboutExpert> AboutExperts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<AboutBlog> AboutBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Owl> Owls { get; set; }
        public DbSet<Data> Data { get; set; }
    }
}
