using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MySite2.Models;

namespace MySite2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            var empList = db.Employees.ToList();

            return View(empList);
        }
    }
}