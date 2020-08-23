using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dealer1.Entity
{
    [Table("usuario")]
    public partial class usuario : entidadbase
    {       [Key]
        public int id { get; set; }

        [StringLength(10)]
        public string nombre { get; set; }

        [StringLength(10)]
        public string pass { get; set; }
       

        /*public virtual Marca Marca { get; set; }*/
      

        /* public virtual TipoCombustible TipoCombustible { get; set; }*/

        /* public virtual TipoTransmision TipoTransmision { get; set; }*/
    

    }
}
