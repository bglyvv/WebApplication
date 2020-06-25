using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
