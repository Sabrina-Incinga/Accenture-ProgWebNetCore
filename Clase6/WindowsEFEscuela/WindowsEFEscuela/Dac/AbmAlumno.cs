using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Datos;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public class AbmAlumno
    {
        private static DbEscuelaBootcampContext context = new DbEscuelaBootcampContext();

        public static List<Alumno> ListAll()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno GetById(int id)
        {
            return context.Alumnos.Find(id);
        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }

        public static int Update(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);

            if(alumnoOrigen != null)
            {
                alumnoOrigen.Nombre = alumno.Nombre;
                alumnoOrigen.Apellido = alumno.Apellido;
                alumnoOrigen.FechaNacimiento = alumno.FechaNacimiento;
                alumnoOrigen.ProfesorId = alumno.ProfesorId;
            }

            return context.SaveChanges();
        }

        public static int Delete(int id)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(id);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
            }

            return context.SaveChanges();
        }
    }
}
