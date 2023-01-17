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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarCategorias();
        }

        private void MostrarCategorias()
        {
            GridCategoria.DataSource = AbmCategoria.Listar();
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Categoria categoria = AbmCategoria.TraerUna(id);
            MessageBox.Show(categoria.Nombre);


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmCategoria.Actualizar(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarCategorias();

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmCategoria.Eliminar(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarCategorias();

            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text };

            int filasAfectadas = AbmCategoria.Insertar(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarCategorias();

            }

        }
    }
}
