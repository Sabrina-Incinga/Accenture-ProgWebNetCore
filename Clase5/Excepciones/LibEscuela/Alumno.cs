using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibEscuela
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Apellido { get; set; }

        private string Nombre;
        public string nombre
        {
            get { return Nombre; }
            set {
                if (value.Trim().Length < 1)
                {
                    throw new Exception("El nombre no puede estar vacío");
                }
                else if (value.Trim().Length > 50)
                {
                    throw new Exception("El nombre no puede tener más de 50 caracteres");
                }
                else
                {
                    Nombre = value.Trim();
                }
            }
        }

    }
}
