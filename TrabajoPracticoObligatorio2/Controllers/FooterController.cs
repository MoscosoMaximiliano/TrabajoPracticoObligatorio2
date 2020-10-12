using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrabajoPracticoObligatorio2.Controllers
{
    public class FooterController : Controller
    {
        // GET: Footer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Footer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Footer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Footer/Create
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

        // GET: Footer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Footer/Edit/5
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

        // GET: Footer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Footer/Delete/5
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
