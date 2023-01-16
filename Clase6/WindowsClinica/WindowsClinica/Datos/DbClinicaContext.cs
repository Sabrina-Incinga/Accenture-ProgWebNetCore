using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClinica.Models;

namespace WindowsClinica.Datos
{
    internal class DbClinicaContext : DbContext
    {
        public DbClinicaContext() : base("KeyDb")
        {
        }

        public DbSet<Clinica> Clinicas { get; set; }

        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
