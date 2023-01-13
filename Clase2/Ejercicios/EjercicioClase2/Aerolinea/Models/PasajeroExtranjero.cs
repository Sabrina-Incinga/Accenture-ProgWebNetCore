using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Models.Base;

namespace Aerolinea.Models
{
    public class PasajeroExtranjero:Pasajero
    {
        public string Pasaporte { get; set; }

        public PasajeroExtranjero(string nombre, string apellido, string pasaporte):base(nombre, apellido)
        {
            Pasaporte = pasaporte;
        }
    }
}
