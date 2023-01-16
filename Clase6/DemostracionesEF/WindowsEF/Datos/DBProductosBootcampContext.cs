using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEF.Models;

namespace WindowsEF.Datos
{
    public class DBProductosBootcampContext : DbContext
    {
        //constructor
        public DBProductosBootcampContext() : base("KeyDB")
        {
        }

        //propiedades DBSET
        public DbSet<Categoria> Categorias { get; set; }
    }
}
