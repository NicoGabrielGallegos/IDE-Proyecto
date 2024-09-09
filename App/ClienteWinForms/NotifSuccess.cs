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

        public NotifSuccess(string msg)
        {
            InitializeComponent();
            label1.Text = $"{msg}";
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
