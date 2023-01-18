using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Datos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Negocio
{
    public static class AbmAvion
    {
        private static DacAvion dac = new DacAvion();

        public static List<Avion> Listar()
        {
            return dac.Listar();
        }

        public static int Insertar(Avion avion)
        {
            return dac.Insertar(avion);
        }

        public static Avion BuscarPorId(int id)
        {
            return dac.BuscarPorId(id);
        }

        public static int Actualizar(Avion avion)
        {
            return dac.Actualizar(avion);
        }

        public static int Eliminar(int id)
        {
            return dac.Eliminar(id);
        }
    }
}
