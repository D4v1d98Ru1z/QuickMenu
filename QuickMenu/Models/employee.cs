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

    public partial class employee
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "This field is required")]
        public string email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required")]
        public string password { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string name { get; set; }
        public string position { get; set; }
        public string LoginError { get; set; }
        public string AddEError { get; set; }
    }
}
