using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clave1___Grupo1
{
    public partial class FormRegistroCliente : Form
    {
        public FormRegistroCliente()
        {
            InitializeComponent();
        }

        //cierre del form 
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void BtnNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtClienteNombre.Text != "" && TxtClienteDireccion.Text != "" && TxtClienteTelefono.Text != "" && TxtNuevoClienteUsuario.Text != "" && TxtNuevoClienteContrasenia.Text != "")
                {
                    //creamos un nuevo objeto usuario para agregar sus propiedades base 
                    Usuario nuevoCliente = new Usuario();
                    nuevoCliente.nombreUsuario = TxtNuevoClienteUsuario.Text;
                    nuevoCliente.contraseña = TxtNuevoClienteContrasenia.Text;
                    nuevoCliente.rol = "Cliente";

                    nuevoCliente.Nombre = TxtClienteNombre.Text;
                    nuevoCliente.Direccion = TxtClienteDireccion.Text;
                    nuevoCliente.Telefono = Convert.ToInt32(TxtClienteTelefono.Text);

                    int crearUsuario = UsuarioDAL.AgregarUsuario(nuevoCliente);
         
                    if (crearUsuario == 1)
                    {
                        MessageBox.Show("Cliente y usuario agregado correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
                else
                {
                    MessageBox.Show("Debe ingresar los datos correspondientes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception error) 
            {
                MessageBox.Show($"Ha ocurrido un error. {error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //validación para evitar ingreso de números
        private void TxtClienteNombre_TextChanged(object sender, EventArgs e)
        {
            Match match;
            string patron = @"^\d+$";
            match = Regex.Match(TxtClienteNombre.Text, patron);
            if (match.Success)
            {
                MessageBox.Show("Debe ingresar sólo letras.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClienteNombre.Clear(); 
            }
        }

        private void TxtClienteTelefono_TextChanged(object sender, EventArgs e)
        {
            Match match;
            string patron = @"^[a-zA-Z]+$";
            match = Regex.Match(TxtClienteTelefono.Text, patron);
            if (match.Success)
            {
                MessageBox.Show("Sólo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtClienteTelefono.Clear();
            }
        }
    }
}
