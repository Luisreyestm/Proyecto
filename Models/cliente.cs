using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Colmado2.Models
{
    public class cliente
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        public string cedula { get; set; }
        [Required]
        public string numeroDeTelefono { get; set; }
        [Required]
        public string email { get; set; }

    }
}