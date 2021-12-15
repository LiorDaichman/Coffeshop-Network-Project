using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
       
        public ActionResult ViewHomePage()
        {
            return View("Home");
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }

        public ActionResult Login()
        {
            return View("Login");
        }
        
        public ActionResult Menu()
        {
            return View("Menu");
        }
    }
}