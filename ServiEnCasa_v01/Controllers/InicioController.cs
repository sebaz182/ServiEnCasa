using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServiEnCasa_v01.Controllers
{
    public class InicioController : Controller
    {
        public void CargaInicial()
        {
            Models.ModeloContainer db = new Models.ModeloContainer();
            ControlController cc = new ControlController();

            if (db.Perfiles.Count() == 0)
            {
                //Perfiles
                Models.Perfiles p1 = new Models.Perfiles();
                p1.Perfil = "Administradores";
                p1.Activo = true;
                db.Perfiles.Add(p1);
                db.SaveChanges();

                Models.Perfiles p2 = new Models.Perfiles();
                p2.Perfil = "Usuarios";
                p2.Activo = true;
                db.Perfiles.Add(p2);
                db.SaveChanges();

                Models.Perfiles p3 = new Models.Perfiles();
                p3.Perfil = "Servis";
                p3.Activo = true;
                db.Perfiles.Add(p3);

                db.SaveChanges();


                //Administrador
                Models.Administradores a1 = new Models.Administradores();
                a1.Nombre = "Admin";
                a1.Apellido = "Admin";
                a1.Email = "admin@admin.com";
                a1.Pass = cc.Encriptar("admin1234");
                Models.Perfiles per = new Models.Perfiles();
                per = db.Perfiles.Where(x => x.Perfil == "Administradores").FirstOrDefault();
                a1.Perfiles.Add(per);
                a1.Activo = true;
                db.Administradores.Add(a1);

                db.SaveChanges();
            }
        }
    }
}