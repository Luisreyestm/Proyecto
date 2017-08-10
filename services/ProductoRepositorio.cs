using Colmado2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Colmado2.services
{
    public class ProductoRepositorio
    {
        public List<Productos> ObtenerTodos()
        {
            using (var db = new ColmadoContext())
            {
                return db.Producto.ToList();
            }
        }

        internal void crear(Productos model)
        {
            using (var db = new ColmadoContext())
            {
                db.Producto.Add(model);
                db.SaveChanges();

            }
                
        }
    }
}