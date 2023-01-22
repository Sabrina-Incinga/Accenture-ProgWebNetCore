using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_showProduct_Click(object sender, EventArgs e)
        {
            Empresa proveedor = new Empresa() { Nombre = "Pedro Picapiedra", Contacto = "pedro1@mail.com", CUIT = "27-25468421-2", Email = "pedrito@mail.com", Direccion = "Calle oscura numero tanteando", Telefono = "3846578912" };
            Producto producto = new Producto();
            producto.Nombre = "Auricular bluetooth";
            producto.Descripcion = "Auricular con cancelación de sonido y bluetooth";
            producto.IVA = 0.21;
            producto.PrecioCosto = 13558.86M;
            producto.Margen = 0.30;
            producto.Proveedor = proveedor;
            producto.Categoria = "Audio";
            producto.SubCategoria = "Auriculares";

            MessageBox.Show($"El producto es un {producto.Nombre}, de la categoría {producto.Categoria} y subcategoría {producto.SubCategoria}, {producto.Descripcion}. " +
                $"Su precio de costo es de {producto.PrecioCosto}, el IVA corresponde a un {producto.IVA*100}% y el margen de ganancia a un {producto.Margen*100}%. " +
                $"El producto fue provisto por el proveedor {producto.Proveedor.Nombre}, cuyo contacto es {producto.Proveedor.Contacto}." +
                $"El precio bruto del mismo es {producto.PrecioBruto} y el precio final de venta es {producto.PrecioVenta}");
        }

        private void btn_showCustomer_Click(object sender, EventArgs e)
        {
            ClienteIndividuo cliente = new ClienteIndividuo() { Nombre = "Pablo", Apellido = "Mármol", CUIT = "26-28564365-7", Direccion = "Al lado de Pedro", Email = "pablito@mail.com", Telefono = "3845453658" };

            MessageBox.Show($"El cliente comprador corresponde a un cliente individuo y su nombre es {cliente.Nombre} {cliente.Apellido}. Número de cuit {cliente.CUIT}, habita {cliente.Direccion}." +
                $"Se puede contactar por mail a {cliente.Email} o a su número telefónico {cliente.Telefono}.");
        }
    }
}
