using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoffeShop.Models
{
    public class CustomerClass
    {
        [Key]
        [Required(ErrorMessage = "Username field is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password field is required")]
        public string Password { get; set; }
    }
}