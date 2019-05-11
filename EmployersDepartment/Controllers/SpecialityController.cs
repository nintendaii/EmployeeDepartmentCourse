using EmployersDepartment.Models;
using DataLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployersDepartment.Controllers;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.SpecialityProcessor;
using System.Data.SqlClient;

namespace EmployersDepartment.Controllers
{
    public class SpecialityController : Controller
    {
        // GET: Speciality
        public ActionResult AddSpeciality()
        {
            ViewBag.Message = "Add A New Position";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSpeciality(SpecialityModel model)
        {
            if (ModelState.IsValid)
            {
                int record = CreateSpeciality(model.SpecialityName,
                    model.SpecialityEducation);
                return RedirectToAction("ViewSpecialities");
            }

            return View();
        }
        public ActionResult ViewSpecialities()
        {
            ViewBag.Message = "Specialities List";
            var data = LoadSpecialities();
            List<SpecialityModel> specialities = new List<SpecialityModel>();
            foreach (var row in data)
            {
                specialities.Add(new SpecialityModel
                {
                     SpecialityName=row.SpecialityName,
                     SpecialityEducation=row.SpecialityEducation
                });
            }
            return View(specialities);
        }
    }
}