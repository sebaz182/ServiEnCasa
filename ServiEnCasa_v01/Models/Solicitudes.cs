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
    
    public partial class Solicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitudes()
        {
            this.Contador = 0;
            this.Presupuestos = new HashSet<Presupuestos>();
        }
    
        public int Id_Ssolisitud { get; set; }
        public string Estado { get; set; }
        public int Contador { get; set; }
        public string Foto { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Zona { get; set; }
        public string Desc_Solicitud { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Presupuestos> Presupuestos { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}