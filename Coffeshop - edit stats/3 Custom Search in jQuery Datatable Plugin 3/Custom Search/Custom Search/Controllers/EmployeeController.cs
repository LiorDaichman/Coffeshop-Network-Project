using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Custom_Search.Models;

namespace Custom_Search.Controllers
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
            List<Employee> empList = new List<Employee>();
            using (DBModel db = new DBModel())
            {
                empList = db.Employees.ToList<Employee>();
                return Json(new { data = empList},JsonRequestBehavior.AllowGet);
            }

        }
	}
}