using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Datos;
using WindowsEF.Models;

namespace WindowsEF.Dac
{
    public class AbmProducto
    {
        public static DBProductosBootcampContext context = new DBProductosBootcampContext();

        public static List<Producto> Listar()
        {
            return context.Productos.ToList();
        }

        public static Producto TraerUna(int id)
        {
            return context.Productos.Find(id);
        }

        public static int Insertar(Producto producto)
        {
            context.Productos.Add(producto);

            return context.SaveChanges();
        }

        public static int Actualizar(Producto producto)
        {
            Producto productoOrigen = context.Productos.Find(producto.Id);
            productoOrigen.Nombre = producto.Nombre;
            return context.SaveChanges();
        }

        public static int Eliminar(Producto producto)
        {
            Producto productoOrigen = context.Productos.Find(producto.Id);

            if (productoOrigen != null)
            {
                context.Productos.Remove(productoOrigen);
            }

            return context.SaveChanges();
        }
    }
}
