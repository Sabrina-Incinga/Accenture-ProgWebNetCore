using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        public int Id { get; set; }

        [Column(TypeName ="varchar"),StringLength(50), Required]
        public string Nombre { get; set; }
        public List<Producto> Productos { get; set; }
        /*[Column(TypeName ="money")]
        public decimal? Algo { get; set; }//nullable*/
    }
}
