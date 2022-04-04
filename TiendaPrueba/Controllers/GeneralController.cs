using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TiendaPrueba.Controllers
{
    public class GeneralController : Controller
    {
        // GET: General
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Institution()
        {
            return View();
        }

        public ActionResult Provider()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        public ActionResult AdvanceSettings()
        {
            return View();
        }

        public ActionResult Book()
        {
            return View();
        }

        public ActionResult Catalog()
        {
            return View();
        }

        public ActionResult Category()
        {
            return View();
        }

        public ActionResult ListPersona()
        {
            return View();
        }

        public ActionResult ListAdmin()
        {
            return View();
        }

        public ActionResult ListCategory()
        {
            return View();
        }

        public ActionResult ListProvider()
        {
            return View();
        }

        public ActionResult ListSection()
        {
            return View();
        }

        public ActionResult ListStudent()
        {
            return View();
        }

        public ActionResult ListTeacher()
        {
            return View();
        }

        public ActionResult Loan()
        {
            return View();
        }

        public ActionResult LoanPending()
        {
            return View();
        }

        public ActionResult LoanReservation()
        {
            return View();
        }

        public ActionResult Personal()
        {
            return View();
        }

        public ActionResult Report()
        {
            return View();
        }

        public ActionResult SearchBook()
        {
            return View();
        }

        public ActionResult Section()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Teacher()
        {
            return View();
        }

        // GET: General/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: General/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: General/Create
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

        // GET: General/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: General/Edit/5
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

        // GET: General/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: General/Delete/5
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
