using Negocio;
using Servicios.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteWinForms
{
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Close();
        }

        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtPass0.Text == txtPass1.Text)
            {
                Usuario usuario = new Usuario();
                usuario.DNI = int.Parse(txtDNI.Text);
                usuario.Nombre = txtNombre.Text;
                usuario.Apellido = txtApellido.Text;
                usuario.Email = txtEmail.Text;
                usuario.Direccion = txtDireccion.Text;
                usuario.FechaNacimiento = DateOnly.FromDateTime(dateFechaNacimiento.Value);
                usuario.Clave = txtPass0.Text;
                await UsuarioNegocio.Add(usuario);
                Close();
            }
        }
    }
}
