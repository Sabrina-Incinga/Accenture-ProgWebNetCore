using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPoo.Comercio
{
    public class DatosContacto
    {
        public int Id { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Empleado Empleado { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
