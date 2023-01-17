using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Producto")]
    public class Producto
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Nombre { get; set; }
        [Column(TypeName = "money")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }

        #region Propiedades de navegación 
        [ForeignKey("CategoriaId")]
        public Categoria categoria { get; set; }
        #endregion

    }
}
