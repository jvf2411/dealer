using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dealer1.Datamodel;
using dealer1.Entity;

namespace dealer1.Formulario
{
    public partial class vehiculoreg : Form

    {
        dealerrepos<Vehiculo> _vehiculo = new dealerrepos<Vehiculo>();
        public vehiculoreg()
        {
            InitializeComponent();
        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {
            _vehiculo.create(new Vehiculo
            {
                TipoTransmisionId = int.Parse(transmisiontxt.Text),
                TipoCombustibleId = int.Parse(tcombustible.Text),
                ModeloId = int.Parse(modelotxt.Text),
                Chasis = chasistxt.Text,
                Placa = placatxt.Text,
                Año = yeartxt.Text,
                Color = colortxt.Text,
                Cilindraje = cilindrajetxt.Text,
                KilometrosTablero = kmtxt.Text,
                CantidadPuertas = int.Parse(puertatxt.Text),
                Precio = int.Parse(preciotxt.Text)
            });
        }
    }
}
