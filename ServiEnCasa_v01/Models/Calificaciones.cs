//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiEnCasa_v01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Calificaciones
    {
        public int Id_Calificacion { get; set; }
        public string Obs_Servi { get; set; }
        public string Obs_Usuario { get; set; }
        public Nullable<bool> Cumplimiento { get; set; }
        public Nullable<int> Cal_Servi { get; set; }
        public Nullable<int> Cal_Usuario { get; set; }
        public Nullable<int> Cal_Trabajo { get; set; }
    
        public virtual Servicios Servicios { get; set; }
    }
}
