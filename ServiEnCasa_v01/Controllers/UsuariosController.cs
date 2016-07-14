using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class UsuariosController : Controller
    {
        private ModeloContainer db = new ModeloContainer();
        ControlController cc = new ControlController();
        
        // GET: Usuarios
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        // GET: Usuarios/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Usuarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        public ActionResult Create(CrearUsuarioViewModel vmUsuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var usuario = new Usuarios { Nombre = vmUsuario.nombre, Apellido = vmUsuario.apellido, Email = vmUsuario.mail, Pass = cc.Encriptar(vmUsuario.pass), Telefono=vmUsuario.telefono};
                    if (cc.ValidarEmail(usuario.Email.ToString()) == false)
                    {
                        usuario.Activo = true;
                        Perfiles p = db.Perfiles.Where(x => x.Perfil == "Usuarios").FirstOrDefault();
                        usuario.Perfiles.Add(p);
                        db.Usuarios.Add(usuario);
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

        // GET: Usuarios/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Usuarios/Edit/5
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

        // GET: Usuarios/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Usuarios/Delete/5
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
