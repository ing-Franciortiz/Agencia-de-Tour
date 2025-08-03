using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agencia_de_tour
{
    public partial class FormActualizar : Form
    {
        public string TourIDToUpdate { get; set; }

        private Dictionary<string, decimal> preciosBasePorPais = new Dictionary<string, decimal>()
        {
            { "República Dominicana", 2500m },
            { "México", 2200m },
            { "Colombia", 2000m },
            { "España", 2700m },
            { "Estados Unidos", 3000m },
            { "Brasil", 2300m }
        };

        private Dictionary<string, List<string>> destinosPorPais = new Dictionary<string, List<string>>()
        {
            { "República Dominicana", new List<string> { "La Vega", "Punta Cana", "Samaná", "Santo Domingo" } },
            { "México", new List<string> { "Cancún", "CDMX", "Guadalajara" } },
            { "Colombia", new List<string> { "Cartagena", "Bogotá", "Medellín" } },
            { "España", new List<string> { "Barcelona", "Madrid", "Valencia" } },
            { "Estados Unidos", new List<string> { "Miami", "Nueva York", "Los Ángeles" } },
            { "Brasil", new List<string> { "Río de Janeiro", "São Paulo", "Brasilia" } }
        };

        public FormActualizar()
        {
            InitializeComponent();
            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());
            cmbDuracion.Items.AddRange(new string[] { "1MES", "2MES", "3MES", "4MES", "5MES", "6MES", "7MES", "10MES", "14MES", "20MES" });
        }

        private void FormActualizar_Load(object sender, EventArgs e)
        {
            CargarDatosTour();
        }

        private void CargarDatosTour()
        {
            if (string.IsNullOrEmpty(TourIDToUpdate)) return;

            var lineas = File.ReadAllLines("tours_nuevo.csv");
            var tourData = lineas.FirstOrDefault(l => l.StartsWith(TourIDToUpdate + ";"));

            if (tourData != null)
            {
                var partes = tourData.Split(';');
                txtID.Text = partes[0];
                txtNombreTour.Text = partes[1];
                cmbPais.SelectedItem = partes[2];

                // Cargar destinos
                var destinos = partes[3].Split('|').ToList();
                foreach (var destino in destinos)
                {
                    int index = clbDestino.Items.IndexOf(destino.Trim());
                    if (index >= 0)
                    {
                        clbDestino.SetItemChecked(index, true);
                    }
                }

                cmbDuracion.SelectedItem = partes[4];
                txtPrecio.Text = partes[5];
                txtITBIS.Text = partes[6];

                // Actualizar el precio y el ITBIS
                ActualizarPrecio();
            }
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paisSeleccionado = cmbPais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(paisSeleccionado)) return;

            // Limpiar destinos y agregar los nuevos
            clbDestino.Items.Clear();
            if (destinosPorPais.ContainsKey(paisSeleccionado))
            {
                // Agregar destinos al CheckedListBox
                clbDestino.Items.AddRange(destinosPorPais[paisSeleccionado].ToArray());

                // Seleccionar automáticamente el primer destino si hay destinos disponibles
                if (clbDestino.Items.Count > 0)
                {
                    clbDestino.SetItemChecked(0, true); // Selecciona el primer destino
                }
            }

            // Actualizar el precio y el ITBIS
            ActualizarPrecio();
        }



        private void ActualizarPrecio()
        {
            // Obtener el país seleccionado
            string pais = cmbPais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(pais)) return;

            // Obtener el precio base
            if (!preciosBasePorPais.ContainsKey(pais)) return;
            decimal precioBase = preciosBasePorPais[pais];

            // Contar destinos seleccionados
            int cantidadCiudades = clbDestino.CheckedItems.Count;

            // Ajustar el precio según la cantidad de destinos
            if (cantidadCiudades == 1)
                precioBase *= 0.60m;
            else if (cantidadCiudades == 2)
                precioBase *= 1.70m;
            else if (cantidadCiudades >= 3)
                precioBase *= 2.00m;

            // Calcular el ITBIS
            decimal precioFinal = precioBase; // Aquí puedes aplicar más lógica si es necesario
            txtPrecio.Text = precioFinal.ToString("0.00");
            decimal itbis = precioFinal * 0.18m;
            txtITBIS.Text = itbis.ToString("0.00");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("El ID no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lineas = File.ReadAllLines("tours_nuevo.csv").ToList();
            var tourData = lineas.FirstOrDefault(l => l.StartsWith(txtID.Text + ";"));

            if (tourData != null)
            {
                var partes = tourData.Split(';');

                // Actualizar solo los campos que no están vacíos
                partes[1] = string.IsNullOrEmpty(txtNombreTour.Text) ? partes[1] : txtNombreTour.Text; // Nombre
                partes[2] = cmbPais.SelectedItem?.ToString() ?? partes[2]; // País
                partes[3] = string.Join(" | ", clbDestino.CheckedItems.Cast<string>().ToList()); // Destinos
                partes[4] = cmbDuracion.SelectedItem?.ToString() ?? partes[4]; // Duración
                partes[5] = string.IsNullOrEmpty(txtPrecio.Text) ? partes[5] : txtPrecio.Text; // Precio
                partes[6] = string.IsNullOrEmpty(txtITBIS.Text) ? partes[6] : txtITBIS.Text; // ITBIS

                // Reemplazar la línea original con la actualizada
                lineas[lineas.IndexOf(tourData)] = string.Join(";", partes);
                File.WriteAllLines("tours_nuevo.csv", lineas);

                MessageBox.Show("Tour actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario después de guardar
            }
            else
            {
                MessageBox.Show("No se encontró el tour para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}






















