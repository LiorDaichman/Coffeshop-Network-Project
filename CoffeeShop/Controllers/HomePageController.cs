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
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult ViewHomePage()
        {
            return View("Home");
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }
    }
}