using LineaAerea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineaAerea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarAvion_Click(object sender, EventArgs e)
        {
            LineaAereaModel lineaAerea = new LineaAereaModel() { Id = 1, FechaInicioActividades = new DateTime(), Nombre = "Avianca" };
            Avion avion = new AvionComercial() { Id = 1, Azafata = "Karen", Piloto = "Pepe", Copiloto = "Julia", Capacidad = 150, LineaAerea = lineaAerea };

            MessageBox.Show(avion.ToString());
        }
    }
}
