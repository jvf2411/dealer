using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dealer1.Entity
{

    [Table("Cliente")]
    public partial class Cliente : entidadbase
    {
        public Cliente()
        {
            this.Venta = new HashSet<Venta>();
        }
        [Key]
        [Required]
        public int ClienteId { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Apellido { get; set; }

        [StringLength(500)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(11)]
        public string Cedula { get; set; }

      
        [Required]
        public ICollection<Venta> Venta { get; set; }
    }
}
