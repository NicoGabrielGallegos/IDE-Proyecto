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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            new FormSignIn().Show();
            Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Task<Usuario> task = UsuarioNegocio.GetByDNI(int.Parse(txtDNI.Text));
            Usuario? usuario = await task;

            if (usuario.Clave == txtPassword.Text)
            {
                new FormSeleccionarPerfil(usuario).Show();
                Close();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
