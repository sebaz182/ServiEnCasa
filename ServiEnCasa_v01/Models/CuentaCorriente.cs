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
    
    public partial class CuentaCorriente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuentaCorriente()
        {
            this.Credito = 0m;
            this.Debito = 0m;
            this.Importe = 0m;
        }
    
        public int Id_CtaCorriente { get; set; }
        public decimal Credito { get; set; }
        public decimal Debito { get; set; }
        public decimal Importe { get; set; }
    
        public virtual Servis Servis { get; set; }
    }
}