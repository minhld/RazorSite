using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySite.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var emps = from e in db.Employees orderby e.ID select e;
            return View(emps);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee e)
        {
            try
            {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/ID
        public IActionResult Edit(int ID) 
        {
            // var emp = from e in db.Employees select e.ID == ID;
            var emp = db.Employees.Single(m => m.ID == ID);
            return View(emp);
        }

        
    }
}
