using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesPoo.Docente
{
    public class Docente
    {
        public int Id { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
