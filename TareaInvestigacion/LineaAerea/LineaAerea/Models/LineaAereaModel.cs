using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaAerea.Models
{
    public class LineaAereaModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicioActividades { get; set; }
        public List<Avion> Aviones { get; set; }
    }
}
