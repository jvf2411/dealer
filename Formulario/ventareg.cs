using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dealer1.Entity;
using dealer1.Datamodel;

namespace dealer1.Formulario
{
    public partial class ventareg : Form
    {
        dealerrepos<Venta> _venta = new dealerrepos<Venta>();
        public ventareg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {
            _venta.create(new Venta
            {
                ClienteId = int.Parse(clientetxt.Text),
                VehiculoId = int.Parse(vehiculotxt.Text),
                MetodoPago = pagotxt.Text,
                Precio = decimal.Parse(preciotxt.Text)
            });
        }
    }
}
