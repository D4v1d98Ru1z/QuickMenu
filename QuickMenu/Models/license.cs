//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuickMenu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class license
    {
        public System.DateTime last_payment { get; set; }
        public string restaurant_name { get; set; }
    
        public virtual restaurant restaurant { get; set; }
    }
}
