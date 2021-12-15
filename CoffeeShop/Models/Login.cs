using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class Login
    {
        [Required]
        [Key]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}