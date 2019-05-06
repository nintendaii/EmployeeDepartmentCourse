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
                int record=CreateEmployee(model.FirstName,
                    model.LastName,
                    model.Age,
                    model.Email,
                    model.SpecialityId,
                    model.PositionId);
                return RedirectToAction("Index");
            }

            return View();
        }
        public ActionResult DeleteEmployee()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBDepartmnet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            ViewBag.Message="Delete Employee";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("delete from dbo.Employee where Id=2002", connection);
            command.ExecuteNonQuery();
            connection.Close();
            return RedirectToAction("ViewEmployees");
        }
    }
}