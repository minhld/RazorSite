using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

using MySite2.Models;

namespace MySite2.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();

        // GET: Employee
        public ActionResult Index()
        {
            var empList = (from e in db.Employees
                          join c in db.Companies on e.Company equals c.Id
                          select new { Name = e.Name,
                                       Age = e.Age,
                                       Email = e.Email,
                                       Company = c.Name,
                                       Address = e.Address }).ToList();

            return View(empList);
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public string SubmitSearch(string keys)
        {
            var empList = (from e in db.Employees
                           join c in db.Companies on e.Company equals c.Id
                           where e.Name.Contains(keys)
                           select new
                           {
                               Name = e.Name,
                               Age = e.Age,
                               Email = e.Email,
                               Company = c.Name,
                               Address = e.Address
                           }).ToList();

            JavaScriptSerializer serial = new JavaScriptSerializer();
            return serial.Serialize(empList);
        }

        [HttpPost]
        public string SubmitSearchByAge(int keys)
        {
            var empList = (from e in db.Employees
                           join c in db.Companies on e.Company equals c.Id
                           where e.Age >= keys
                           select new
                           {
                               Name = e.Name,
                               Age = e.Age,
                               Email = e.Email,
                               Company = c.Name,
                               Address = e.Address
                           }).ToList();

            JavaScriptSerializer serial = new JavaScriptSerializer();
            return serial.Serialize(empList);
        }

        [HttpPost]
        public string SubmitSearchByCompany(string keys)
        {
            var empList = (from e in db.Employees
                           join c in db.Companies on e.Company equals c.Id
                           where c.Name.Contains(keys)
                           select new
                           {
                               Name = e.Name,
                               Age = e.Age,
                               Email = e.Email,
                               Company = c.Name,
                               Address = e.Address
                           }).ToList();

            JavaScriptSerializer serial = new JavaScriptSerializer();
            return serial.Serialize(empList);
        }
    }
}