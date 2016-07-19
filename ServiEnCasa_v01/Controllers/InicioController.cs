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

            if (db.Usuarios.Count() == 0)
            {

                Models.Perfiles per = new Models.Perfiles();
                per = db.Perfiles.Where(x => x.Perfil == "Usuarios").FirstOrDefault();

                Models.Usuarios u1 = new Models.Usuarios();
                u1.Nombre = "Usuario1";
                u1.Apellido = "Usuario1";
                u1.Email = "user1@user.com";
                u1.Pass = cc.Encriptar("user1234");
                u1.Telefono = "156888999";
                u1.Perfiles.Add(per);
                u1.Activo = true;
                db.Usuarios.Add(u1);

                Models.Usuarios u2 = new Models.Usuarios();
                u2.Nombre = "Usuario2";
                u2.Apellido = "Usuario2";
                u2.Email = "user2@user.com";
                u2.Pass = cc.Encriptar("user1234");
                u2.Telefono = "156888999";
                u2.Perfiles.Add(per);
                u2.Activo = true;
                db.Usuarios.Add(u2);

                Models.Usuarios u3 = new Models.Usuarios();
                u3.Nombre = "Usuario3";
                u3.Apellido = "Usuario3";
                u3.Email = "user3@user.com";
                u3.Pass = cc.Encriptar("user1234");
                u3.Telefono = "156888999";
                u3.Perfiles.Add(per);
                u3.Activo = true;
                db.Usuarios.Add(u3);
            }

            //Iniciar las Zonas
            if (db.Zonas.Count() == 0)
            {
                Models.Zonas z1 = new Models.Zonas();
                z1.Zona = "Rosario Centro";
                db.Zonas.Add(z1);

                Models.Zonas z2 = new Models.Zonas();
                z2.Zona = "Rosario Norte";
                db.Zonas.Add(z2);

                Models.Zonas z3 = new Models.Zonas();
                z3.Zona = "Rosario Sur";
                db.Zonas.Add(z3);

                Models.Zonas z4 = new Models.Zonas();
                z4.Zona = "Rosario Oeste";
                db.Zonas.Add(z4);

                db.SaveChanges();
            }

            //Iniciar las Horarios
            if (db.Horarios.Count() == 0)
            {
                Models.Horarios h1 = new Models.Horarios();
                h1.Horario = "8:00Hs - 12:00Hs";
                db.Horarios.Add(h1);

                Models.Horarios h2 = new Models.Horarios();
                h2.Horario = "12:00Hs - 16:00Hs";
                db.Horarios.Add(h2);

                Models.Horarios h3 = new Models.Horarios();
                h3.Horario = "16:00Hs - 19:00Hs";
                db.Horarios.Add(h3);

                db.SaveChanges();
            }

            //Iniciar Profesiones
            if (db.Profesiones.Count() == 0)
            {
                Models.Profesiones p1 = new Models.Profesiones();
                p1.Desc_Profesion = "Electricista";
                db.Profesiones.Add(p1);

                Models.Profesiones p2 = new Models.Profesiones();
                p2.Desc_Profesion = "Gasista";
                db.Profesiones.Add(p2);

                Models.Profesiones p3 = new Models.Profesiones();
                p3.Desc_Profesion = "Plomero";
                db.Profesiones.Add(p3);

                Models.Profesiones p4 = new Models.Profesiones();
                p4.Desc_Profesion = "Service Aire Acondicionado";
                db.Profesiones.Add(p4);

                Models.Profesiones p5 = new Models.Profesiones();
                p5.Desc_Profesion = "Servicio Domestico";
                db.Profesiones.Add(p5);

                db.SaveChanges();
            }

            //Iniciar Tareas
            if (db.Tareas.Count() == 0)
            {
                //Tareas para Los Electrisistas
                Models.Profesiones prof1 = new Models.Profesiones();
                prof1 = db.Profesiones.Where(x => x.Desc_Profesion == "Electricista").FirstOrDefault();

                Models.Tareas t01 = new Models.Tareas();
                t01.Desc_Tarea = "Instalar";
                t01.Profesiones = prof1;
                db.Tareas.Add(t01);

                Models.Tareas t02 = new Models.Tareas();
                t02.Desc_Tarea = "Reparar";
                t02.Profesiones = prof1;
                db.Tareas.Add(t02);

                Models.Tareas t03 = new Models.Tareas();
                t03.Desc_Tarea = "Sustituir";
                t03.Profesiones = prof1;
                db.Tareas.Add(t03);

                Models.Tareas t04 = new Models.Tareas();
                t04.Desc_Tarea = "Cablear";
                t04.Profesiones = prof1;
                db.Tareas.Add(t04);

                Models.Tareas t05 = new Models.Tareas();
                t05.Desc_Tarea = "Otro";
                t05.Profesiones = prof1;
                db.Tareas.Add(t05);

                //Tareas para Gasistas
                Models.Profesiones prof2 = new Models.Profesiones();
                prof2 = db.Profesiones.Where(x => x.Desc_Profesion == "Gasista").FirstOrDefault();

                Models.Tareas t11 = new Models.Tareas();
                t11.Desc_Tarea = "Revisar perdida de Gas";
                t11.Profesiones = prof2;
                db.Tareas.Add(t11);

                Models.Tareas t12 = new Models.Tareas();
                t12.Desc_Tarea = "Habilitar Instalación";
                t12.Profesiones = prof2;
                db.Tareas.Add(t12);

                Models.Tareas t13 = new Models.Tareas();
                t13.Desc_Tarea = "Realizar Instalación";
                t13.Profesiones = prof2;
                db.Tareas.Add(t13);

                Models.Tareas t14 = new Models.Tareas();
                t14.Desc_Tarea = "Realizar Service";
                t14.Profesiones = prof2;
                db.Tareas.Add(t14);

                Models.Tareas t15 = new Models.Tareas();
                t15.Desc_Tarea = "Otro";
                t15.Profesiones = prof2;
                db.Tareas.Add(t15);

                //Tareas para Plomero
                Models.Profesiones prof3 = new Models.Profesiones();
                prof3 = db.Profesiones.Where(x => x.Desc_Profesion == "Plomero").FirstOrDefault();

                Models.Tareas t21 = new Models.Tareas();
                t21.Desc_Tarea = "Instalar";
                t21.Profesiones = prof3;
                db.Tareas.Add(t21);

                Models.Tareas t22 = new Models.Tareas();
                t22.Desc_Tarea = "Reparar";
                t22.Profesiones = prof3;
                db.Tareas.Add(t22);

                Models.Tareas t23 = new Models.Tareas();
                t23.Desc_Tarea = "Sustituir";
                t23.Profesiones = prof3;
                db.Tareas.Add(t23);

                Models.Tareas t24 = new Models.Tareas();
                t24.Desc_Tarea = "Otro";
                t24.Profesiones = prof3;
                db.Tareas.Add(t24);

                //Tareas para Service Aire Acondicionado
                Models.Profesiones prof4 = new Models.Profesiones();
                prof4 = db.Profesiones.Where(x => x.Desc_Profesion == "Service Aire Acondicionado").FirstOrDefault();

                Models.Tareas t31 = new Models.Tareas();
                t31.Desc_Tarea = "Instalar";
                t31.Profesiones = prof4;
                db.Tareas.Add(t31);

                Models.Tareas t32 = new Models.Tareas();
                t32.Desc_Tarea = "Reparar";
                t32.Profesiones = prof4;
                db.Tareas.Add(t32);

                Models.Tareas t33 = new Models.Tareas();
                t33.Desc_Tarea = "Sustituir";
                t33.Profesiones = prof4;
                db.Tareas.Add(t33);

                Models.Tareas t34 = new Models.Tareas();
                t34.Desc_Tarea = "Recargar";
                t34.Profesiones = prof4;
                db.Tareas.Add(t34);

                Models.Tareas t35 = new Models.Tareas();
                t35.Desc_Tarea = "Otro";
                t35.Profesiones = prof4;
                db.Tareas.Add(t35);

                //Tareas para Servicio Domestico
                Models.Profesiones prof5 = new Models.Profesiones();
                prof5 = db.Profesiones.Where(x => x.Desc_Profesion == "Servicio Domestico").FirstOrDefault();

                Models.Tareas t41 = new Models.Tareas();
                t41.Desc_Tarea = "Servicio Completo";
                t41.Profesiones = prof5;
                db.Tareas.Add(t41);

                Models.Tareas t42 = new Models.Tareas();
                t42.Desc_Tarea = "Cocina";
                t42.Profesiones = prof5;
                db.Tareas.Add(t42);

                Models.Tareas t43 = new Models.Tareas();
                t43.Desc_Tarea = "Limpieza";
                t43.Profesiones = prof5;
                db.Tareas.Add(t43);

                Models.Tareas t44 = new Models.Tareas();
                t44.Desc_Tarea = "Lavado y Planchado";
                t44.Profesiones = prof5;
                db.Tareas.Add(t44);

                Models.Tareas t45 = new Models.Tareas();
                t45.Desc_Tarea = "Niñera";
                t45.Profesiones = prof5;
                db.Tareas.Add(t45);

                Models.Tareas t46 = new Models.Tareas();
                t46.Desc_Tarea = "Otro";
                t46.Profesiones = prof5;
                db.Tareas.Add(t46);

                db.SaveChanges();
            }


            if (db.Servis.Count() == 0)
            {
                //Perfil de Servi
                Models.Perfiles per = new Models.Perfiles();
                per = db.Perfiles.Where(x => x.Perfil == "Servis").FirstOrDefault();

                //Electricistas
                Models.Profesiones prof1 = new Models.Profesiones();
                prof1 = db.Profesiones.Where(x => x.Desc_Profesion == "Electricista").FirstOrDefault();
                //Tareas del Electricista
                Models.Tareas tar1 = new Models.Tareas();
                tar1 = db.Tareas.Where(x => x.Desc_Tarea == "Instalar" && x.Profesiones.Desc_Profesion == "Electricista").FirstOrDefault();

                Models.Tareas tar2 = new Models.Tareas();
                tar2 = db.Tareas.Where(x => x.Desc_Tarea == "Cablear" && x.Profesiones.Desc_Profesion == "Electricista").FirstOrDefault();

                Models.Tareas tar3 = new Models.Tareas();
                tar3 = db.Tareas.Where(x => x.Desc_Tarea == "Otro" && x.Profesiones.Desc_Profesion == "Electricista").FirstOrDefault();

                Models.Tareas tar4 = new Models.Tareas();
                tar4 = db.Tareas.Where(x => x.Desc_Tarea == "Sustituir" && x.Profesiones.Desc_Profesion == "Electricista").FirstOrDefault();

                Models.Tareas tar5 = new Models.Tareas();
                tar5 = db.Tareas.Where(x => x.Desc_Tarea == "Reparar" && x.Profesiones.Desc_Profesion == "Electricista").FirstOrDefault();
                //
                //
                Models.Servis s1 = new Models.Servis();
                s1.Nombre = "Electricista 1";
                s1.Apellido = "Servi";
                s1.Email = "servi1@servi.com";
                s1.Pass = "user1234";
                s1.Telefono = "4641525";
                s1.Matricula = "m12345";
                s1.Foto = "~/Content/img/electricista.jpg";
                s1.DNI = "33444555";
                s1.Activo = true;
                s1.Profesiones.Add(prof1);
                s1.Perfiles.Add(per);
                s1.Tareas.Add(tar1);
                s1.Tareas.Add(tar2);
                s1.Tareas.Add(tar3);
                db.Servis.Add(s1);


                Models.Servis s2 = new Models.Servis();
                s2.Nombre = "Electricista 2";
                s2.Apellido = "Servi";
                s2.Email = "servi2@servi.com";
                s2.Pass = "user1234";
                s2.Telefono = "4641525";
                s2.Matricula = "m12345";
                s2.Foto = "~/Content/img/electricista2.jpg";
                s2.DNI = "33444555";
                s2.Activo = true;
                s2.Profesiones.Add(prof1);
                s2.Perfiles.Add(per);
                s2.Tareas.Add(tar4);
                s2.Tareas.Add(tar5);
                db.Servis.Add(s2);


                //Plomero
                Models.Profesiones prof2 = new Models.Profesiones();
                prof2 = db.Profesiones.Where(x => x.Desc_Profesion == "Plomero").FirstOrDefault();
                //Tareas del Plomero
                Models.Tareas tarp1 = new Models.Tareas();
                tarp1 = db.Tareas.Where(x => x.Desc_Tarea == "Instalar" && x.Profesiones.Desc_Profesion == "Plomero").FirstOrDefault();

                Models.Tareas tarp2 = new Models.Tareas();
                tarp2 = db.Tareas.Where(x => x.Desc_Tarea == "Otro" && x.Profesiones.Desc_Profesion == "Plomero").FirstOrDefault();

                Models.Tareas tarp3 = new Models.Tareas();
                tarp3 = db.Tareas.Where(x => x.Desc_Tarea == "Sustituir" && x.Profesiones.Desc_Profesion == "Plomero").FirstOrDefault();

                Models.Tareas tarp4 = new Models.Tareas();
                tarp4 = db.Tareas.Where(x => x.Desc_Tarea == "Reparar" && x.Profesiones.Desc_Profesion == "Plomero").FirstOrDefault();
                //
                //
                Models.Servis s3 = new Models.Servis();
                s3.Nombre = "Plomero 1";
                s3.Apellido = "Servi";
                s3.Email = "servi3@servi.com";
                s3.Pass = "user1234";
                s3.Telefono = "4641525";
                s3.Matricula = "m12345";
                s3.Foto = "~/Content/img/plomero.jpg";
                s3.DNI = "33444555";
                s3.Activo = true;
                s3.Profesiones.Add(prof2);
                s3.Perfiles.Add(per);
                s3.Tareas.Add(tarp1);
                s3.Tareas.Add(tarp2);
                s3.Tareas.Add(tarp3);
                s3.Tareas.Add(tarp4);
                db.Servis.Add(s3);

                db.SaveChanges();
            }

        }
    }
}