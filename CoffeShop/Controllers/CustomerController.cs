using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeShop.DAL;
using CoffeShop.Models;

namespace CoffeShop.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult LoadData()
        {
            return View();
        }

        public ActionResult Enter()
        {
            return View(new CustomerClass());
        }

        public ActionResult Submit(CustomerClass cust)
        {

            if (ModelState.IsValid)
            {
                CustomerDAL Dal = new CustomerDAL();
                Dal.customers.Add(cust);
                Dal.SaveChanges();
                return View("LoadData", cust);
            }
            else
                return View("Enter", cust);
        }
        
    }
}