using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        private decimal precioBruto;
        public decimal PrecioBruto
        {
            get
            {
                precioBruto = Convert.ToDecimal(1 + this.Margen) * PrecioCosto;
                return precioBruto;
            }
        }
        private decimal precioVenta;
        public decimal PrecioVenta
        {
            get
            {
                precioVenta = Convert.ToDecimal(1 + this.IVA) * precioBruto;
                return precioVenta;
            }
        }

        public Proveedor Proveedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }

    }
}
