using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class ServisController : Controller
    {
        private ModeloContainer db = new ModeloContainer();
        ControlController cc = new ControlController();

        // GET: Servis
        public ActionResult Index()
        {
            return View(db.Servis.ToList());
        }

        // GET: Servis/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Servis/Create
        [HttpGet]
        public ActionResult Create(int? ProfesionID)
        {
            if (ProfesionID == null)
            {
                ViewBag.ProfesionID = new SelectList(db.Profesiones.ToList(), "Id_Profesion", "Desc_Profesion");
                ViewBag.TareaID = new SelectList(db.Tareas.ToList(), "Id_Tarea", "Desc_Tarea");
                //ViewBag.TareaID = new SelectList(db.Tareas.Where(x => x.Profesiones.Id_Profesion == ProfesionID).ToList(), "Id_Tarea", "Desc_Tarea");
                return View();
            }
            else
            {
                ViewBag.ProfesionID = new SelectList(db.Profesiones.ToList(), "Id_Profesion", "Desc_Profesion");
                ViewBag.TareaID = new SelectList(db.Tareas.Where(x => x.Profesiones.Id_Profesion == ProfesionID).ToList(), "Id_Tarea", "Desc_Tarea");
                return View();
            }
        }

        public JsonResult GetTareas(int selectedcampo)
        {
            var resultado = db.Tareas.Where(x => x.Profesiones.Id_Profesion == selectedcampo).ToList();
            return Json(resultado, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Busqueda(int? ProfesionID)
        {
            if (ProfesionID == null)
            {
                ViewBag.ProfesionID = new SelectList(db.Profesiones.ToList(), "Id_Profesion", "Desc_Profesion");
                ViewBag.TareaID = db.Tareas.Where(x => x.Profesiones.Id_Profesion == ProfesionID).ToList();
                return View();
            }
            else
            {

                ViewBag.ProfesionID = new SelectList(db.Profesiones.ToList(), "Id_Profesion", "Desc_Profesion");
                ViewBag.TareaID = db.Tareas.Where(x => x.Profesiones.Id_Profesion == ProfesionID).ToList();
                return View();
            }
            
        }

        // POST: Servis/Create
        [HttpPost]
        public ActionResult Create(CreateServiViewModel vmServi, params string[] selectedTareas)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var prof = db.Profesiones.Find(vmServi.ProfesionID);
                    var servi = new Servis { Nombre = vmServi.nombre, Apellido = vmServi.apellido, Email = vmServi.mail, Pass = cc.Encriptar(vmServi.pass), Telefono = vmServi.telefono,  };
                    if (cc.ValidarEmail(servi.Email.ToString()) == false)
                    {
                        if (selectedTareas != null)
                        {
                            Tareas t = db.Tareas.Where(x=>x.Desc_Tarea == "Cableado").FirstOrDefault();
                            servi.Tareas.Add(t);
                            //selectedTareas = selectedTareas ?? new string[] { };
                            //await this.GroupManager
                            //    .SetUserGroupsAsync(user.Id, selectedGroups);
                        }
                        servi.Profesiones.Add(prof);
                        servi.Activo = true;
                        Perfiles p = db.Perfiles.Where(x => x.Perfil == "Servi").FirstOrDefault();
                        servi.Perfiles.Add(p);
                        //agregar datos extras
                        servi.DNI = "33222111";
                        servi.Matricula = "3444";
                        servi.Foto = "foto.jpg";
                        db.Servis.Add(servi);
                        db.SaveChanges();
                        return RedirectToAction("Index");
                    }
                }
                return View();
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Servis/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Servis/Edit/5
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

        // GET: Servis/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Servis/Delete/5
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
