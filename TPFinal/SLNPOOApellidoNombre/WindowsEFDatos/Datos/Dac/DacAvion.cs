using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Datos.Dac
{
    public class DacAvion
    {
        private static DBLineaAereaContext contexto = new DBLineaAereaContext();

        public List<Avion> Listar()
        {
            return contexto.Aviones.ToList();
        }
        
        public int Insertar(Avion avion)
        {
            contexto.Aviones.Add(avion);

            return contexto.SaveChanges();
        }
    }
}
