using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_tour
{
    public partial class FormSalir : Form
    {
        public FormSalir()
        {
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra todo el programa

        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close(); // Solo cierra este formulario

        }

        private void lblMensaje_Click(object sender, EventArgs e)
        {

        }
    }
}
