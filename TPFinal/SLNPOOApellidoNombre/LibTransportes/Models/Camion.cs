using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class Camion:Vehiculo
    {
        public string Tamanio { get; set; }
        public Remolque Remolque { get; set; }
        public Camion(int id, string marca, string modelo, float velocidad, float velocidadMax, string tamanio) : base(id, marca, modelo, velocidad, velocidadMax)
        {
            Tamanio = tamanio;
        }
        public Camion(int id, string marca, string modelo, float velocidad, float velocidadMax, string tamanio, Remolque remolque) : base(id, marca, modelo, velocidad, velocidadMax)
        {
            Tamanio = tamanio;
            Remolque = remolque;
        }

        public void QuitarRemolque() 
        {
            this.Remolque = null;
        }

        public override string Imprimir()
        {
            if(this.Remolque != null)
            {
                return $"Vehículo de tipo {this.GetType().Name}." + base.Imprimir() + $", Tamaño: {this.Tamanio}, Remolque de capacidad máxima: {this.Remolque.CapacidadMax}";
            } else return $"Vehículo de tipo {this.GetType().Name}." + base.Imprimir() + $", Tamaño: {this.Tamanio}, Remolque de capacidad máxima: Sin remolque";

        }

        public override string Acelerar()
        {
            string message;
            if (this.VelocidadActual < this.VelocidadMax)
            {
                this.VelocidadActual += 30;
                message = $"La velocidad aumentó a {this.VelocidadActual}";
            }
            else
            {
                this.VelocidadActual = this.VelocidadMax;
                message = $"Su vehículo alcanzó la velocidad máxima de {this.VelocidadMax}";
            }

            return message;
        }

        public override string Frenar()
        {
            string message;
            if (this.VelocidadActual > 0)
            {
                this.VelocidadActual -= 110;
                message = $"La velocidad disminuyó a {this.VelocidadActual}";
            }
            else
            {
                this.VelocidadActual = 0;
                message = $"Su vehículo está detenido";
            }
            return message;
        }
    }
}
