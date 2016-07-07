using System;
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
}