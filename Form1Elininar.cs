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
        private List<Tour> _listaTours;

        public Form1Elininar(List<Tour> listaTours)
        {
            InitializeComponent();
            _listaTours = listaTours;
        }

        private void btnEliminarTour_Click(object sender, EventArgs e)
        {
            try
            {
                string idEliminar = txtIdEliminar.Text.Trim();
                if (string.IsNullOrEmpty(idEliminar))
                {
                    MessageBox.Show("Por favor, ingrese el ID del tour a eliminar.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Tour tourAEliminar = _listaTours.Find(t => t.Id == idEliminar);

                if (tourAEliminar != null)
                {
                    DialogResult resultado = MessageBox.Show(
                        $"¿Está seguro de que desea eliminar el tour '{tourAEliminar.Nombre}' con ID: {tourAEliminar.Id}?",
                        "Confirmar Eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        _listaTours.Remove(tourAEliminar);
                        MessageBox.Show("Tour eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); // Cierra el formulario después de eliminar
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún tour con el ID: {idEliminar}", "Tour No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar el tour: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}





