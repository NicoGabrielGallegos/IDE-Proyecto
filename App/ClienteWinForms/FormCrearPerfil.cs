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
    public partial class FormCrearPerfil : Form
    {
        private Usuario _usuario;

        public FormCrearPerfil(Usuario usuario)
        {
            _usuario = usuario;
            InitializeComponent();
            txtDNI.Text = _usuario.DNI.ToString();
        }

        private void radioBtnAlumno_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEspecialidad.Enabled = true;
        }

        private void radioBtnDocente_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEspecialidad.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
