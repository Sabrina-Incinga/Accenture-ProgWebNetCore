using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aerolinea.Models.Base;

namespace Aerolinea.Models
{
    public class PasajeroNacional:Pasajero
    {
        public string DNI { get; set; }

        public PasajeroNacional(string nombre, string apellido, string dNI):base(nombre, apellido)
        {
            DNI = dNI;
        }
    }
}
