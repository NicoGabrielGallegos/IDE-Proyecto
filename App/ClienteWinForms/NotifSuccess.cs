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
    public partial class NotifSuccess : Form
    {
        TextBox Nombre;
        TextBox Apellido;
        public NotifSuccess(TextBox nombre, TextBox apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            InitializeComponent();
            label2.Text = $"Bienvenido {Nombre.Text}, {Apellido.Text}.";
        }


        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void NotifSuccess_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
