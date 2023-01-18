using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models
{
    public class AutoElectrico : Vehiculo
    {
        public string Voltaje { get; set; }
        public AutoElectrico(int id, string marca, string modelo, float velocidad, float velocidadMax, string voltaje):base(id, marca, modelo, velocidad, velocidadMax)
        {
            Voltaje = voltaje;
        }

        public override string Acelerar()
        {
            string message;
            if (this.VelocidadActual < this.VelocidadMax)
            {
                this.VelocidadActual += 10;
                message = $"La velocidad aumentó a {this.VelocidadActual}";
            }
            else 
            {
                VelocidadActual = VelocidadMax;
                message = $"Su vehículo alcanzó la velocidad máxima de {this.VelocidadMax}"; 
            }

            return message;
        }

        public override string Frenar()
        {
            string message;
            if (this.VelocidadActual > 0)
            {
                this.VelocidadActual -= 100;
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
