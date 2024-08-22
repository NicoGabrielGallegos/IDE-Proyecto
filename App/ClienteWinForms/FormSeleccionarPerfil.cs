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
    public partial class FormSeleccionarPerfil : Form
    {
        private Usuario _usuario;
        private Task<IEnumerable<object>>? _perfiles;

        public FormSeleccionarPerfil(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            lblWelcome.Text = $"Hola {_usuario.Nombre}, {_usuario.Apellido}! Selecciona un perfil o crea uno nuevo";
            recargarPerfiles();
        }

        public IEnumerable<object> cargarPerfiles()
        {
            _perfiles = PerfilNegocio.GetDataGridViewFormattedByDNIUsuario(_usuario.DNI);
            return _perfiles.Result;
        }

        private async void recargarPerfiles() {
            Task<IEnumerable<object>> task = new Task<IEnumerable<object>>(cargarPerfiles);
            task.Start();
            dataGridViewPerfiles.DataSource = await task;
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

        private void btnRecargarPerfiles_Click(object sender, EventArgs e)
        {
            recargarPerfiles();
        }
    }
}
