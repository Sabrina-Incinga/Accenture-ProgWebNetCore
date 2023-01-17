using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarTodo();
        }

        private void MostrarTodo()
        {
            gridAlumnos.DataSource = AbmAlumno.ListAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text), ProfesorId = Convert.ToInt32(txtProfesorId.Text) };

            int filasAfectadas = AbmAlumno.Insert(alumno);

            if(filasAfectadas > 0)
            {
                MessageBox.Show("Alumno correctamente agregado");
                MostrarTodo();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() {IdAlumno = Convert.ToInt32(txtId.Text), Nombre = txtNombre.Text, Apellido = txtApellido.Text, FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text), ProfesorId = Convert.ToInt32(txtProfesorId.Text) };

            int filasAfectadas = AbmAlumno.Update(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Alumno correctamente actualizado");
                MostrarTodo();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumno alumno = AbmAlumno.GetById(Convert.ToInt32(txtId.Text));

            if (alumno != null)
            {
                MessageBox.Show(alumno.Nombre + " " + alumno.Apellido);
                MostrarTodo();
            }
            else MessageBox.Show("Alumno no encontrado");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasModificadas = AbmAlumno.Delete(Convert.ToInt32(txtId.Text));

            if(filasModificadas > 0)
            {
                MessageBox.Show("Alumno eliminado correctamente");
                MostrarTodo();
            }
        }


    }
}
