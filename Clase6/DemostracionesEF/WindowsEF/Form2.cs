using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Dac;
using WindowsEF.Models;

namespace WindowsEF
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            GridProducto.DataSource = AbmProducto.Listar();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Producto producto = AbmProducto.TraerUna(id);
            MessageBox.Show(producto.Nombre);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Producto
            Producto producto = new Producto() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmProducto.Actualizar(producto);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarProductos();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Producto
            Producto producto = new Producto() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmProducto.Eliminar(producto);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarProductos();

            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Producto
            Producto producto = new Producto() { Nombre = txtNombre.Text };

            int filasAfectadas = AbmProducto.Insertar(producto);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarProductos();

            }

        }
    }
}
