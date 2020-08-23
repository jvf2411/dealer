using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dealer1.Entity
{
   public class entidadbase
    {
        [StringLength(2)]
        public string Estatus { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(255)]
        public string creadopor { get; set; }

        [StringLength(255)]
        public string Modificadopor { get; set; }
    }
}
