using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DepartmentalSurvey.Models;

namespace DepartmentalSurvey.Controllers
{
    public class SchoolYearController : Controller
    {
        private DepartmentalSurveyEntities db = new DepartmentalSurveyEntities();


        // GET: SchoolYear
        public ActionResult Index()
        {
            return View();
        }

        // GET: SchoolYear/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SchoolYear/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SchoolYear/Create
        [HttpPost]
        public ActionResult Create(SchoolYear schoolyear)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.SchoolYear.Add(schoolyear);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View(schoolyear);
            }
        }

        // GET: SchoolYear/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SchoolYear/Edit/5
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

        // GET: SchoolYear/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SchoolYear/Delete/5
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
