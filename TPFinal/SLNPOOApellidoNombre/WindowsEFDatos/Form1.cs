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

            if(lineaAerea != null)
            {
                Avion avion = new Avion() { Capacidad=txtCapacidad.Text, Denominacion=txtDenominacion.Text, IdLinea= id};
                AbmAvion.Insertar(avion);   
            } else
            {
                lineaAerea = new LineaAerea() { Nombre="Avianca", FechaInicioActividades=new DateTime(2015, 12, 30)};
                AbmLineaAerea.Insertar(lineaAerea);
                Avion avion = new Avion() { Capacidad = txtCapacidad.Text, Denominacion = txtDenominacion.Text, IdLinea = lineaAerea.IdLinea};
                AbmAvion.Insertar(avion);
            }
            MostrarAviones();
            MessageBox.Show("Avion insertado correctamente");

        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }

        private void MostrarAviones()
        {
            gridAviones.DataSource = AbmAvion.Listar();
        }
    }
}
