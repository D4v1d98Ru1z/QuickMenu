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
    using System.ComponentModel.DataAnnotations;

    public partial class restaurant
    {
        public restaurant()
        {
            this.license = new HashSet<license>();
        }

        [Required(ErrorMessage = "This field is required")]
        public string name { get; set; }
        public string user_email { get; set; }
        public string AddRError { get; set; }

        public virtual ICollection<license> license { get; set; }
        public virtual user user { get; set; }
    }
}
