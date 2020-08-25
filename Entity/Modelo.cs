using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace dealer1.Entity
{
    [Table("Modelo")]
    public partial class Modelo : entidadbase
    {   
        public Modelo()
        {
            this.Vehiculo = new HashSet<Vehiculo>();
        }

        [Key]
        [Required]
        public int ModeloId { get; set; }

        public int? MarcaId { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }


  
        [Required]
        public ICollection<Vehiculo> Vehiculo{ get; set; }
    }
}
