using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class SolicitudesController : Controller
    {
        private ModeloContainer db = new ModeloContainer();

        // GET: Solicitudes
        [HttpGet]
        public ActionResult MisSolicitudes()
        {
            return View(db.Solicitudes.ToList());
        }

        // GET: Solicitudes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Solicitudes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Solicitudes/Create
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

        // GET: Solicitudes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Solicitudes/Edit/5
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

        // GET: Solicitudes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Solicitudes/Delete/5
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
