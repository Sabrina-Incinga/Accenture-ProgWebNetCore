using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class ClienteIndividuo : Persona
    {
        public string Apellido { get; set; }
        public string CUIT { get; set; }
    }
}
