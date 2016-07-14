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
    public class ControlController : Controller
    {

        private ModeloContainer db = new ModeloContainer();

        public string Encriptar(string pass)
        {
            byte[] passBytes = Encoding.Unicode.GetBytes(pass);

            SHA1 sha = SHA1.Create();

            byte[] hash = sha.ComputeHash(passBytes);

            string hashString = Encoding.Unicode.GetString(hash);

            return hashString;
        }

        public bool ValidarEmail(string e)
        {
            foreach (Usuarios oUsuario in db.Usuarios.ToList())
            {
                if (oUsuario.Email.ToUpper() == e.ToUpper())
                {
                    return true;
                }
            }
            foreach (Servis oServi in db.Servis.ToList())
            {
                if (oServi.Email.ToUpper() == e.ToUpper())
                {
                    return true;
                }
            }
            foreach (Administradores oAdmin in db.Administradores.ToList())
            {
                if (oAdmin.Email.ToUpper() == e.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

    }
}