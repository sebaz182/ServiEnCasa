using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class PresupuestosController : Controller
    {
        private ModeloContainer db = new ModeloContainer();

        [HttpGet]
        public ActionResult PresupuestosSolicitud(int id)
        {
            return View(db.Presupuestos.Where(x=>x.Solicitudes.Id_Solicitud==id).ToList());
        }

        // GET: Presupuestos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Presupuestos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Presupuestos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Presupuestos/Create
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

        // GET: Presupuestos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Presupuestos/Edit/5
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

        // GET: Presupuestos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Presupuestos/Delete/5
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
