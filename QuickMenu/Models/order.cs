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

    public partial class order
    {
        public order()
        {
            this.orderdetail = new HashSet<orderdetail>();
        }
    
        public int idorder { get; set; }
        public double totalprice { get; set; }
        public int table { get; set; }
        public string paymentmethod { get; set; }
        public string status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime date { get; set; }
        public string AddOError { get; set; }

        public virtual ICollection<orderdetail> orderdetail { get; set; }
    }
}
