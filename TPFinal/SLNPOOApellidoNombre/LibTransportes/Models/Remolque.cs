using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Remolque
    {
        public int Id { get; set; }
        public string CapacidadMax { get; set; }

        public Remolque(int id, string capacidadMax)
        {
            Id = id;
            CapacidadMax = capacidadMax;
        }
    }
}
