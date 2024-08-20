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
    public partial class FormRegistroUsuariosTest : Form
    {
        public FormRegistroUsuariosTest()
        {
            InitializeComponent();
        }

        private async void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordR.Text)
            {
                return;
            }
            Usuario u = new Usuario();
            /*
            u.Nombre_Usuario = txtNombreUsuario.Text;
            u.Clave = txtPassword.Text;
            u.Habilitado = false;
            u.Nombre = txtNombre.Text;
            u.Apellido = txtApellido.Text;
            u.Email = txtEmail.Text;
            u.Cambia_Clave = null;
            u.Id_Persona = null;
            */
            await UsuarioNegocio.Add(u);
            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
