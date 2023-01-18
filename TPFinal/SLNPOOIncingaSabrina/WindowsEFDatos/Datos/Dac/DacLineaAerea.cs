using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Datos.Dac
{
    public class DacLineaAerea
    {
        private static DBLineaAereaContext contexto = new DBLineaAereaContext();

        public LineaAerea BuscarPorId(int id)
        {
            return contexto.LineasAereas.Find(id);
        }

        internal int Insertar(LineaAerea lineaAerea)
        {
            contexto.LineasAereas.Add(lineaAerea);

            return contexto.SaveChanges();
        }
    }
}
