using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaAerea.Models
{
    public class AvionComercial : Avion
    {
        public int Capacidad { get; set; }
        public LineaAereaModel LineaAerea { get; set; }

        public override void Aterriza()
        {
            throw new NotImplementedException();
        }

        public override void Despega()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            if(LineaAerea != null)
            {
                return $"Avión de tipo: {GetType().Name}. Tripulación: {Piloto}, {Copiloto}, {Azafata}. Capacidad: {Capacidad} personas, Linea aérea: {LineaAerea.Nombre}";
            }
            return $"Avión de tipo: {GetType().Name}. Tripulación: {Piloto}, {Copiloto}, {Azafata}. Capacidad: {Capacidad} personas";

        }
    }
}
