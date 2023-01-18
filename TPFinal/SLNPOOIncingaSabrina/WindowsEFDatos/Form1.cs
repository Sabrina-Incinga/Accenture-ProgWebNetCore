using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Models;
using WindowsEFDatos.Negocio;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAvion_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdLinea.Text);
            LineaAerea lineaAerea = AbmLineaAerea.BuscarPorId(id);
            int filasAfectadas;

            if (lineaAerea != null)
            {
                Avion avion = new Avion() { Capacidad=txtCapacidad.Text, Denominacion=txtDenominacion.Text, IdLinea= id};
                filasAfectadas = AbmAvion.Insertar(avion);   
            } else
            {
                lineaAerea = new LineaAerea() { Nombre="Avianca", FechaInicioActividades=new DateTime(2015, 12, 30)};
                AbmLineaAerea.Insertar(lineaAerea);
                Avion avion = new Avion() { Capacidad = txtCapacidad.Text, Denominacion = txtDenominacion.Text, IdLinea = lineaAerea.IdLinea};
                filasAfectadas = AbmAvion.Insertar(avion);
            }
            MostrarAviones();
            MessageBox.Show(filasAfectadas > 0 ? "Avión insertado correctamente" : "No se pudo insertar el avión");

        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void MostrarAviones()
        {
            gridAviones.DataSource = AbmAvion.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdLinea.Text);
            LineaAerea lineaAerea = AbmLineaAerea.BuscarPorId(id);
            int filasAfectadas;

            if (lineaAerea != null)
            {
                Avion avion = new Avion() { IdAvion= Convert.ToInt32(txtId.Text), Capacidad = txtCapacidad.Text, Denominacion = txtDenominacion.Text, IdLinea = id};
                filasAfectadas = AbmAvion.Actualizar(avion);
            }
            else
            {
                lineaAerea = new LineaAerea() { Nombre = "Avianca", FechaInicioActividades = new DateTime(2015, 12, 30) };
                AbmLineaAerea.Insertar(lineaAerea);
                Avion avion = new Avion() { Capacidad = txtCapacidad.Text, Denominacion = txtDenominacion.Text, IdLinea = lineaAerea.IdLinea };
                filasAfectadas = AbmAvion.Actualizar(avion);
            }
            MostrarAviones();
            MessageBox.Show(filasAfectadas >0 ? "Avión actualizado correctamente": "No se pudo actualizar el avión");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AbmAvion.Eliminar(Convert.ToInt32(txtId.Text));

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Avión eliminado correctamente");
            }
            else MessageBox.Show("El avión no existe");
            MostrarAviones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Avion avion = AbmAvion.BuscarPorId(Convert.ToInt32(txtId.Text));

            if (avion != null)
            {
                MessageBox.Show($"Avión con denominación {avion.Denominacion} \nCapacidad {avion.Capacidad} personas \n Perteneciente a línea aérea {avion.LineaAerea.Nombre}");
            }
            else MessageBox.Show("Avión no encontrado");
        }
    }
}
