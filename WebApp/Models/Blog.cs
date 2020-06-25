using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string Header { get; set; }
        [Required, StringLength(150)]
        public string Content { get; set; }
    }
}
