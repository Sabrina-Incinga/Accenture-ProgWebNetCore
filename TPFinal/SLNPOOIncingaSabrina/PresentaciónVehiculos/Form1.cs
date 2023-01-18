using LibTransportes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public static Remolque remolque = new Remolque(1, "500kg");
        public static Camion camion = new Camion(1, "Fiat", "Toro", 300, 330, "4x4", remolque);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarCamion();
        }

        private void MostrarCamion()
        {
            txtCamion.Text = camion.Imprimir() + $" Velocidad actual: {camion.VelocidadActual}";

        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(camion.Acelerar());
            MostrarCamion();
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(camion.Frenar());
            MostrarCamion();
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            camion.QuitarRemolque();
            MostrarCamion();
        }
    }
}
