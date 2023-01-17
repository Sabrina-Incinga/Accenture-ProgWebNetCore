using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Models;
using WindowsEF.Datos;

namespace WindowsEF.Dac
{
    public static class AbmCategoria
    {
        public static DBProductosBootcampContext context = new DBProductosBootcampContext();
        public static List<Categoria> Listar()
        {
            return context.Categorias.ToList();
        }

        public static Categoria TraerUna(int id)
        {
            return context.Categorias.Find(id);
        }

        public static int Insertar(Categoria categoria)
        {
            context.Categorias.Add(categoria);

            return context.SaveChanges();
        }

        public static int Actualizar(Categoria categoria)
        {
            Categoria categoriaOrigen = context.Categorias.Find(categoria.Id);
            categoriaOrigen.Nombre = categoria.Nombre;
            return context.SaveChanges();
        }

        public static int Eliminar(Categoria categoria)
        {
            Categoria categoriaOrigen = context.Categorias.Find(categoria.Id);

            if(categoriaOrigen != null)
            {
                context.Categorias.Remove(categoriaOrigen);
            }

            return context.SaveChanges();
        }
    }
}
