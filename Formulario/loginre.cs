using dealer1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dealer1.Context;
using dealer1.Datamodel;

namespace dealer1.Formulario
{
    public partial class loginre : Form
    {
        dealerrepos<usuario> _usuario = new dealerrepos<usuario>();
        public loginre()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            _usuario.create(new usuario {nombre=nombretxt.Text,pass=passtxt.Text });

        }
    }
}
