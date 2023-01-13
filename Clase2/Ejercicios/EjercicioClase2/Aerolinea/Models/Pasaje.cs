using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerolinea.Models
{
    public class Pasaje
    {
        public double Precio { get; set; }
        public string Destino { get; set; }

        public Pasaje(double precio, string destino)
        {
            Precio = precio;
            Destino = destino;
        }
    }
}
