using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class TareasController : Controller
    {
        // crear una instancia desde la base de datos.
        private ModeloContainer db = new ModeloContainer();
        //
        // GET: Tareas
        public ActionResult Index()
        {
            ViewBag.ProfesionId = new SelectList(db.Profesiones.ToList(), "Id_Profesion", "Desc_Profesion");
            return View(db.Tareas.ToList());
        }
        
        [HttpGet]
        public ActionResult Busqueda(int ProfesionID)
        {
            return View(db.Tareas.Where(x => x.Profesiones.Id_Profesion == ProfesionID).Take(10));
        }

        // GET: Tareas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Tareas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tareas/Create
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

        // GET: Tareas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tareas/Edit/5
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

        // GET: Tareas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tareas/Delete/5
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
