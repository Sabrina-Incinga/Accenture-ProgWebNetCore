using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Datos
{
    public class DBLineaAereaContext : DbContext
    {
        public DBLineaAereaContext() : base("KeyDb")
        {
        }

        public DbSet<Avion> Aviones { get; set; }
        public DbSet<LineaAerea> LineasAereas { get; set; }
    }
}
