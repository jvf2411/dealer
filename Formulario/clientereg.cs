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
    public partial class clientereg : Form
    {
        dealerrepos<Cliente> _cliente = new dealerrepos<Cliente>();
        public clientereg()
        {
            InitializeComponent();
        }

        private void registrarbtn_Click(object sender, EventArgs e)
        {
            _cliente.create(new Cliente { Nombre = nombretxt.Text, Apellido = Apellidotxt.Text, Cedula = cedulatxt.Text, Correo = correotxt.Text, Telefono=telefonotxt.Text,Direccion=dirrecciontxt.Text });
        }
    }
}
