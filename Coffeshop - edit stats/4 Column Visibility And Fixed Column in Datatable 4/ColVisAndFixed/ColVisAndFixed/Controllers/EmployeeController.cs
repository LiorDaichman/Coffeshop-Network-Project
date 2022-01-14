using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ColVisAndFixed.Models;

namespace ColVisAndFixed.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetList()
        {
            List<EmployeeDetail> empList = new List<EmployeeDetail>();
            using (DBModel db = new DBModel())
            {
                empList = db.EmployeeDetails.ToList<EmployeeDetail>();
                return Json(new { data = empList }, JsonRequestBehavior.AllowGet);
            }

        }
    }
}