//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PX.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculo()
        {
            this.Vehiculo_parqueo = new HashSet<Vehiculo_parqueo>();
        }
    
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Color { get; set; }
        public string Linea { get; set; }
        public int Categoria { get; set; }
        public int Conductor { get; set; }
    
        public virtual Categoria Categoria1 { get; set; }
        public virtual Conductor Conductor1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculo_parqueo> Vehiculo_parqueo { get; set; }
    }
}
