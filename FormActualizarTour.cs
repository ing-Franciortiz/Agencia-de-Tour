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
    public partial class FormActualizarTour : Form
    {
        private List<Tour> _listaTours;
        private Tour _tourSeleccionado;

        public FormActualizarTour(List<Tour> listaTours)
        {
            InitializeComponent();
            _listaTours = listaTours;
            grpDatosTour.Enabled = false; // Deshabilita el grupo de datos inicialmente
        }

        private void btnBuscarTour_Click(object sender, EventArgs e)
        {
            try
            {
                string idBuscar = txtIdActualizar.Text.Trim();
                if (string.IsNullOrEmpty(idBuscar))
                {
                    MessageBox.Show("Por favor, ingrese el ID del tour a actualizar.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _tourSeleccionado = _listaTours.Find(t => t.Id == idBuscar);

                if (_tourSeleccionado != null)
                {
                    // Llenar los campos con los datos del tour encontrado
                    txtNombreTour.Text = _tourSeleccionado.Nombre;
                    txtPaisDestino.Text = _tourSeleccionado.PaisDestino;
                    txtDestino.Text = _tourSeleccionado.Destino;
                    dtpFechaTour.Value = _tourSeleccionado.Fecha;
                    dtpHoraTour.Value = DateTime.Today.Add(_tourSeleccionado.Hora); // Asume que Hora es TimeSpan o similar
                    txtPrecio.Text = _tourSeleccionado.Precio.ToString();
                    // ... Cargar otros campos del tour

                    grpDatosTour.Enabled = true; // Habilita el grupo para edición
                    MessageBox.Show("Tour encontrado. Puede modificar sus datos.", "Tour Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No se encontró ningún tour con el ID: {idBuscar}", "Tour No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    grpDatosTour.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar el tour: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (_tourSeleccionado == null)
            {
                MessageBox.Show("Primero debe buscar y seleccionar un tour para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validar y actualizar los datos del tour seleccionado
                _tourSeleccionado.Nombre = txtNombreTour.Text.Trim();
                _tourSeleccionado.PaisDestino = txtPaisDestino.Text.Trim();
                _tourSeleccionado.Destino = txtDestino.Text.Trim();
                _tourSeleccionado.Fecha = dtpFechaTour.Value.Date;
                _tourSeleccionado.Hora = dtpHoraTour.Value.TimeOfDay; // Guardar solo la hora

                if (decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
                {
                    _tourSeleccionado.Precio = precio;
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ... Actualizar otros campos del tour

                MessageBox.Show("Tour actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario después de actualizar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


