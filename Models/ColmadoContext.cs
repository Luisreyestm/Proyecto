using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Colmado2.Models
{
    public class ColmadoContext : DbContext 



    {
        public ColmadoContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<loginRegistration> LoginRegistration { get; set; }
        public DbSet<Productos> Producto { get; set; }
        public DbSet<cliente> cliente { get; set; }
        public DbSet<facturacion> Facturacion { get; set; }
    }
}