using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Colmado2.Models
{
    public class facturacion
    {
        public int id { get; set; }
        public string NombreDelCliente { get; set; }
        public string ProductosComprados { get; set; }
        public DateTime fecha { get; set; }
        public int total { get; set; }
        


    }
}