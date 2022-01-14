using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CoffeShop.Models;

namespace CoffeShop.View_Model
{
    public class CustomerViewModel
    {
        public CustomerClass Customer { get; set; }

        public List<CustomerClass> Customers { get; set; }
    }
}