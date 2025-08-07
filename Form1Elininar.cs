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
    public partial class Form1Elininar : Form

    {

        private FormMostrar frmMostrar;

        public Form1Elininar(FormMostrar mostrarForm)
        {
            InitializeComponent();
            frmMostrar = mostrarForm;
        }


        private void LimpiarCamposUsuario(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox textbox && !textbox.ReadOnly)
                    textbox.Clear();

                else if (ctrl is ComboBox combo && combo.DropDownStyle != ComboBoxStyle.DropDownList)
                    combo.SelectedIndex = -1;

                else if (ctrl is CheckBox checkbox)
                    checkbox.Checked = false;

                else if (ctrl is RadioButton radio)
                    radio.Checked = false;

                else if (ctrl is DateTimePicker picker)
                    picker.Value = DateTime.Now;

                if (ctrl.HasChildren)
                    LimpiarCamposUsuario(ctrl); // recursividad
            }
        }
        private void btnIDEliminar_Click(object sender, EventArgs e)
        {
            string idBuscado = txtID.Text.Trim();
            if (string.IsNullOrEmpty(idBuscado))
            {
                lblResultado.Text = "⚠️ Ingrese un ID válido.";
                return;
            }

            string archivo = "tours_nuevo.csv";
            if (!File.Exists(archivo))
            {
                lblResultado.Text = "📂 El archivo no existe.";
                return;
            }

            var lineas = File.ReadAllLines(archivo).ToList();
            var tourEncontrado = lineas.FirstOrDefault(linea => linea.StartsWith(idBuscado + ";"));

            if (tourEncontrado != null)
            {
                var confirmacion = MessageBox.Show($"¿Desea eliminar el tour con ID {idBuscado}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    lineas.Remove(tourEncontrado);
                    File.WriteAllLines(archivo, lineas);
                    lblResultado.Text = "✅ Tour eliminado correctamente.";
                    LimpiarCamposUsuario(this);


                }
                else
                {
                    lblResultado.Text = " Cancelado por el usuario.";
                }
            }
            else
            {
                lblResultado.Text = "❌ No se encontró ningún tour con ese ID.";
            }



            frmMostrar.CargarTours();
        }


    }
}






