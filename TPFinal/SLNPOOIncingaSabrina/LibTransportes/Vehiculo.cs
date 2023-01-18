using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float VelocidadActual { get; set; }
        public float VelocidadMax { get; set; }

        public Vehiculo(int id, string marca, string modelo, float velocidadActual, float velocidadMax)
        {
            Id = id;
            Marca = marca;
            Modelo = modelo;
            VelocidadActual = velocidadActual;
            VelocidadMax = velocidadMax;
        }

        public virtual string Imprimir()
        {
            return $"Id: {this.Id}, Marca: {this.Marca}, Modelo: {this.Modelo}"; 
        }
        public abstract string Acelerar();
        public abstract string Frenar();
    }
}
