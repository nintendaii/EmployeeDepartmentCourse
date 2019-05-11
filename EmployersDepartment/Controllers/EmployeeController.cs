using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployersDepartment.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Empl
        public ActionResult Index()
        {
            return View();
        }

        // GET: Empl/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empl/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empl/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empl/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Empl/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empl/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
