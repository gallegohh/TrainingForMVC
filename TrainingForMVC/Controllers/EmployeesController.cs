using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrainingForMVC.Models;

namespace TrainingForMVC.Controllers
{
    public class EmployeesController : Controller
    {
        private ModelNorthwind db;

        // GET: Employees
        public ActionResult Index()
        {
            return View(db.Employees.ToList());
        }

        // GET: Employees/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employees());
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(Employees employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(employee);
            }
        }

        public EmployeesController()
        {
            db = new ModelNorthwind();
        }
    }
}