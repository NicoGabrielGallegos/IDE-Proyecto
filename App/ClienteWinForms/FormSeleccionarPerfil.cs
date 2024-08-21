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
    public partial class FormSeleccionarPerfil : Form
    {
        private Usuario _usuario;

        public FormSeleccionarPerfil(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            lblWelcome.Text = $"Hola {_usuario.Nombre}, {_usuario.Apellido}! Selecciona un perfil o crea uno nuevo";
        }

        private void btnCrearPerfil_Click(object sender, EventArgs e)
        {
            new FormCrearPerfil(_usuario).ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Close();
        }
    }
}
