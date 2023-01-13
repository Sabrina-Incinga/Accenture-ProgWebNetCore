using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Models.Base
{
    public abstract class Pasajero
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        protected Pasajero(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
