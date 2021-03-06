﻿using ServiEnCasa_v01.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class HomeController : Controller
    {
        Models.ModeloContainer db = new Models.ModeloContainer();
        public ActionResult Index()
        {
            InicioController i = new InicioController();
            i.CargaInicial();

            ViewBag.Profesiones = db.Profesiones.ToList();
            ViewBag.Tareas = db.Tareas.ToList();
            ViewBag.Horarios = db.Horarios.ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult EnviarSolicitud(SolicitudViewModel model, HttpPostedFileBase fotoupload)
        {
            model.Foto = "";
            if (ModelState.IsValid)
            {
                    try
                    {
                    if (fotoupload != null)
                    {
                        string path = "~/Content/img/" + fotoupload.FileName;
                        model.Foto = path;
                        string fullpath = Server.MapPath("~/Content/img/") + fotoupload.FileName;
                        fotoupload.SaveAs(fullpath);
                    }
                    else
                    {
                        model.Foto = "~/Content/img/sinFoto.png";
                    }


                        var profesiones = db.Profesiones.Find(model.ProfesionId);
                        var tareas = db.Tareas.Find(model.TareaId);
                        var zona = db.Zonas.Where(x=>x.Zona == model.Zona).FirstOrDefault();
                        var hora = db.Horarios.Find(model.idHora);
                        var usuario = db.Usuarios.Where(x => x.Id_Usuario == 1).FirstOrDefault();

                        var solicitud = new Solicitudes
                        {
                            Profesiones = profesiones,
                            Tareas = tareas,
                            Zonas = zona,
                            Desc_Solicitud = model.DescripcionServicio,
                            Estado = "Alta",
                            Fecha = model.FechaInicio,
                            Contador = 0,
                            Foto = model.Foto,
                            Usuarios = usuario,
                            Horarios = hora,
                        };
                        db.Solicitudes.Add(solicitud);
                        db.SaveChanges();
                        
                        ViewBag.Message = "El archivo se ha subido correctamente";
                    }
                    catch (Exception ex)
                    {
                        ViewBag.Message = "ERROR:" + ex.Message.ToString();
                    }
            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult BuscarZonas(string busqueda)
        {
            busqueda = busqueda.ToUpper();
            List<string> zonas = db.Zonas.Where(x => x.Zona.ToUpper().Contains(busqueda)).Select(x=>x.Zona).ToList();

            return Json(zonas, JsonRequestBehavior.AllowGet);
        }

    }
}