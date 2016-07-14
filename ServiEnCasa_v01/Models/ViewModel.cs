﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiEnCasa_v01.Models
{
    public class EditarProfesionViewModels
    {
        public int id { get; set; }

        [Required]
        [Display(Name ="Profesión")]
        public string profesion { get; set; }
    }

    public class CrearProfesionViewModels
    {
        [Required]
        [Display(Name = "Profesión")]
        public string profesion { get; set; }
    }

    public class CrearTareaViewModel
    {
        [Required]
        [Display(Name = "Profesión")]
        public int ProfesionID { get; set; }

        [Required]
        [Display(Name = "Tarea")]
        public string tarea { get; set; }
    }

    public class EditarTareaViewModel
    {
        public int id { get; set; } 

        [Display(Name = "Profesión")]
        public string profesion { get; set; }

        [Required]
        [Display(Name = "Tarea")]
        public string tarea { get; set; }
    }

    public class CrearUsuarioViewModel
    {
        public int id { get ; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string mail { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Confirmar E-Mail")]
        [Compare ("mail",ErrorMessage ="El E-Mail no coincide")]
        public string confMail { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La {0} deberia tener al menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string pass { get; set; }

        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("pass", ErrorMessage = "La contraseña no coincide")]
        [DataType(DataType.Password)]
        public string confPass { get; set; }
    }

    public class CreateAdmiViewModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string mail { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La {0} deberia tener al menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string pass { get; set; }

        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("pass", ErrorMessage = "La contraseña no coincide")]
        [DataType(DataType.Password)]
        public string confPass { get; set; }
    }

    public class CreateServiViewModel
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string mail { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Confirmar E-Mail")]
        [Compare("mail", ErrorMessage = "El E-Mail no coincide")]
        public string confMail { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La {0} deberia tener al menos {2} caracteres.", MinimumLength = 6)]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string pass { get; set; }

        [Required]
        [Display(Name = "Confirmar Contraseña")]
        [Compare("pass", ErrorMessage = "La contraseña no coincide")]
        [DataType(DataType.Password)]
        public string confPass { get; set; }

        [Required]
        [Display(Name = "Profesión")]
        public int ProfesionID { get; set; }

        //[Required]
        [Display(Name = "Tarea")]
        public ICollection<Tareas> Tareas { get; set; }
        
    }
    
}