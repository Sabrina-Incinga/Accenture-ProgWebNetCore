using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaAerea.Models
{
    public abstract class Avion
    {
        public int Id { get; set; }
        public string Piloto { get; set; }
        public string Copiloto { get; set; }
        public string Azafata { get; set; }

        public abstract void Aterriza();
        public abstract void Despega();
    }
}
