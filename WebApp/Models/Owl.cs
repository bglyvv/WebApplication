using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Owl
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Link { get; set; }
    }
}
