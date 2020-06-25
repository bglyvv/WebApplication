using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public AboutVideo AboutVideo { get; set; }
        public IEnumerable<VideoContent> VideoContents { get; set; }
        public AboutExpert AboutExpert { get; set; }
        public IEnumerable<Expert> Experts { get; set; }
        public AboutBlog AboutBlog { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Owl> Owls { get; set; }
    }
}
