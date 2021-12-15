using CoffeeShop.DAL;
using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CheckLogin(Login Check)
        {
            if (ModelState.IsValid)
            {
                LoginDal dal = new LoginDal();
                dal.Login.Add(Check);
                dal.SaveChanges();
                return View("AfterLogin", Check);
            }
            else
            {
                return View("BadLogin", Check);
            }
        }
    }
}