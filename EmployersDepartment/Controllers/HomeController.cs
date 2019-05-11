using EmployersDepartment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.EmployeeProcessor;
using System.Data.SqlClient;

namespace EmployersDepartment.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewEmployees()
        {
            ViewBag.Message = "Employees List";
            var data = LoadEmployees();
            List<EmployeeModel> employees = new List<EmployeeModel>();
            foreach (var row in data)
            {
                employees.Add(new EmployeeModel
                {
                    FirstName=row.FirstName,
                    LastName=row.LastName,
                    Age=row.Age,
                    Email=row.Email,
                    SpecialityId=row.SpecialityId,
                    PositionId=row.PositionId
                });
            }
            return View(employees);
        }
        public ActionResult AddEmployee()
        {
            ViewBag.Message = "Add A New Employee";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddEmployee(EmployeeModel model)
        {
            if (ModelState.IsValid)
            {
                    CreateEmployee(model.FirstName,
                    model.LastName,
                    model.Age,
                    model.Email,
                    model.SpecialityId,
                    model.PositionId);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult DeleteEmployee(int id)
        {
            var data = LoadEmployees();
            
        }

        // POST: Empl/Delete/5
        [HttpPost]
        public ActionResult DeleteEmployee(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}