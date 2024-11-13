using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1___Grupo1
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistroCliente formRegistroCliente = new FormRegistroCliente();
            formRegistroCliente.ShowDialog();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

        }
    }
}
