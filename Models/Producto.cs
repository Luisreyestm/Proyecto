using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Colmado2.Models
{
    public class Productos
    {
        public int id { get; set; }
        [Required]
        [StringLength(25)]
         public string nombre { get; set; }
        [Required]
        [StringLength(15)]
        public string proveedor { get; set; }
       
        public string peso { get; set; }
        public int precio { get; set; }
    }
}