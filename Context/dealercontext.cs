using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using dealer1.Entity;

namespace dealer1.Context
{
    public class dealercontext: DbContext
   
    {
        public dealercontext()
            :base("name=dealer")
        {

        }
        public virtual DbSet<Cliente> Cliente { get; set; }
       /* public virtual DbSet<Marca> Marca { get; set; }*/
        public virtual DbSet<Modelo> Modelo { get; set; }
     
       /* public virtual DbSet<TipoCombustible> TipoCombustible { get; set; }*/
        /*public virtual DbSet<TipoTransmision> TipoTransmision { get; set; }*/
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
    }
}
