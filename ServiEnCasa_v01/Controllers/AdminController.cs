using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class AdminController : Controller
    {
        private ModeloContainer db = new ModeloContainer();
        ControlController cc = new ControlController();

        // GET: Admin
        public ActionResult Index()
        {
            return View(db.Administradores.ToList());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(CreateAdmiViewModel vmAdmin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var admin = new Usuarios { Nombre = vmAdmin.nombre, Apellido = vmAdmin.apellido, Email = vmAdmin.mail, Pass = cc.Encriptar(vmAdmin.pass)};
                    if (cc.ValidarEmail(admin.Email.ToString()) == false)
                    {
                        admin.Activo = true;
                        Perfiles p = db.Perfiles.Where(x => x.Perfil == "Administradores").FirstOrDefault();
                        admin.Perfiles.Add(p);
                        db.Usuarios.Add(admin);
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

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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
