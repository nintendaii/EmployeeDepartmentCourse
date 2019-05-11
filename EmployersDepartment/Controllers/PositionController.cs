using EmployersDepartment.Models;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployersDepartment.Controllers;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.PositionProcessor;
using System.Data.SqlClient;

namespace EmployersDepartment.Controllers
{
    public class PositionController : Controller
    {
        // GET: Position
        public ActionResult AddPosition()
        {
            ViewBag.Message = "Add A New Position";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddPosition(PositionModel model)
        {
            if (ModelState.IsValid)
            {
                int record = CreatePosition(model.PositionName,
                    model.PositionSalary);
                return RedirectToAction("ViewPositions");
            }

            return View();
        }
        public ActionResult ViewPositions()
        {
            ViewBag.Message = "Positions List";
            var data = LoadPositions();
            List<PositionModel> positions = new List<PositionModel>();
            foreach (var row in data)
            {
                positions.Add(new PositionModel
                {
                    PositionName = row.PositionName,
                    PositionSalary = row.PositionSalary
                });
            }
            return View(positions);
        }
    }
}