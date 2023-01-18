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
            List<Avion> aviones = contexto.Aviones.ToList();
            if(aviones.Count > 0)
            {
                foreach (Avion avion in aviones)
                {
                    avion.LineaAerea = contexto.LineasAereas.Find(avion.IdLinea);
                }
            }
            
            return aviones;
        }
        
        public int Insertar(Avion avion)
        {
            contexto.Aviones.Add(avion);

            return contexto.SaveChanges();
        }

        public Avion BuscarPorId(int id)
        {
            Avion avion = contexto.Aviones.Find(id);
            if (avion != null)
            {
                avion.LineaAerea = contexto.LineasAereas.Find(avion.IdLinea);
            }
            
            return avion;
        }

        public int Actualizar(Avion avion)
        {
            Avion avionOrigen = BuscarPorId(avion.IdAvion);
            if(avionOrigen != null)
            {
                avionOrigen.Capacidad = avion.Capacidad;
                avionOrigen.Denominacion = avion.Denominacion;
                avionOrigen.IdLinea = avion.IdLinea;
            }

            return contexto.SaveChanges();
        }

        public int Eliminar(int id)
        {
            Avion avionOrigen = BuscarPorId(id);
            if(avionOrigen != null)
            {
                contexto.Aviones.Remove(avionOrigen);
            }

            return contexto.SaveChanges();
        }
    }
}
