//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articulos
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public string CodigoDeBarra { get; set; }
        public Nullable<int> IdArticuloFamilia { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<System.DateTime> FechaAlta { get; set; }
    }
}
