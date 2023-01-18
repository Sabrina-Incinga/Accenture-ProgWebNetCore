using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Datos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Negocio
{
    public static class AbmLineaAerea
    {
        private static DacLineaAerea dac = new DacLineaAerea();

        public static LineaAerea BuscarPorId(int id)
        {
            return dac.BuscarPorId(id);
        }

        public static int Insertar(LineaAerea lineaAerea)
        {
            return dac.Insertar(lineaAerea);
        }
    }
}
