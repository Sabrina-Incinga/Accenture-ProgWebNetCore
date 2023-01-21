using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaAerea.Models
{
    public class AvionCarga : Avion
    {
        public float Peso { get; set; }
        public string TipoMercaderia { get; set; }
        public override void Aterriza()
        {
            throw new NotImplementedException();
        }

        public override void Despega()
        {
            throw new NotImplementedException();
        }

    }
}
