using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Colmado2.Models
{
    public class loginRegistration
    {
        [Key]
        public int userID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string apellido { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string usuario { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string confirmacionPasword { get; set; }



    }
}