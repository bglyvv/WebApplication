using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class AboutVideo
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Link { get; set; }
        [Required,StringLength(250)]
        public string Header { get; set; }
        [Required,StringLength(300)]
        public string Content { get; set; }
    }
}
