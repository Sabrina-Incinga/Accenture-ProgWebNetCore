using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        [Column(TypeName ="varchar"), StringLength(50), Required]
        public string Estado { get; set; }
        [Column(TypeName ="varchar"), StringLength(250)]
        public string Descripcion { get; set; }
    }
}
