using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dealer1.Entity
{
    [Table("Venta")]
    public partial class Venta : entidadbase
    {
        [Key]
        public int VentaId { get; set; }

        public int ClienteId { get; set; }
        
        public int VehiculoId { get; set; }

        [StringLength(50)]
        public string MetodoPago { get; set; }

        public decimal Precio { get; set; }


        [Required]
        public virtual Cliente Cliente { get; set; }
      
        [Required]
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
