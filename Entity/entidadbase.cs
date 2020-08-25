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

        public bool Borrado { get; set; } = false;

        public DateTime? FechaRegistro { get; set; } = DateTime.Now;

        public DateTime? FechaModificacion { get; set; }

        [StringLength(255)]
        public string creadopor { get; set; }

        [StringLength(255)]
        public string Modificadopor { get; set; }
    }
}
