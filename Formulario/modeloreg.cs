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
    public partial class modeloreg : Form
    {
        dealerrepos<Modelo> _modelo = new dealerrepos<Modelo>();
        public modeloreg()
        {
            InitializeComponent();
        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {
            _modelo.create(new Modelo { MarcaId = int.Parse(marcaid.Text), ModeloId = int.Parse(modelotxt.Text), Nombre = nombretxt.Text });
        }
    }
}
