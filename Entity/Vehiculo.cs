using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dealer1.Entity
{
    [Table("Vehiculo")]
    public partial class Vehiculo : entidadbase
    {
        [Key]
        public int VehiculoId { get; set; }

        public int TipoTransmisionId { get; set; }

        public int TipoCombustibleId { get; set; }

        public int ModeloId { get; set; }
        


        [StringLength(100)]
        public string Chasis { get; set; }

        
        [StringLength(20)]
        public string Placa { get; set; }

        
        [StringLength(4)]
        public string Año { get; set; }

      
        [StringLength(20)]
        public string Color { get; set; }

        
        [StringLength(10)]
        public string Cilindraje { get; set; }

       
        [StringLength(50)]
        public string KilometrosTablero { get; set; }

        public int CantidadPuertas { get; set; }

        public decimal Precio { get; set; }

       

        [Required]

        public virtual Modelo Modelo { get; set; }

        /*  public virtual TipoCombustible TipoCombustible { get; set; }*/

        /* public virtual TipoTransmision TipoTransmision { get; set; }*/
    
        [Required]
        public ICollection<Venta> Venta { get; set; }
    }
}
