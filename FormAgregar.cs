using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agencia_de_tour
{
    public partial class FormAgregar : Form
    {
        Dictionary<string, decimal> preciosBasePorPais = new Dictionary<string, decimal>()
        {
            { "República Dominicana", 2500m },
            { "México", 2200m },
            { "Colombia", 2000m },
            { "España", 2700m },
            { "Estados Unidos", 3000m },
            { "Brasil", 2300m }
        };

        Dictionary<string, List<string>> destinosPorPais = new Dictionary<string, List<string>>()
        {
            { "República Dominicana", new List<string> { "La Vega", "Punta Cana", "Samaná", "Santo Domingo" } },
            { "México", new List<string> { "Cancún", "CDMX", "Guadalajara" } },
            { "Colombia", new List<string> { "Cartagena", "Bogotá", "Medellín" } },
            { "España", new List<string> { "Barcelona", "Madrid", "Valencia" } },
            { "Estados Unidos", new List<string> { "Miami", "Nueva York", "Los Ángeles" } },
            { "Brasil", new List<string> { "Río de Janeiro", "São Paulo", "Brasilia" } }
        };

        public FormAgregar()
        {
            InitializeComponent();
            clbDestino.ItemCheck += clbDestino_ItemCheck;
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;

            cmbPais.Items.Clear();
            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());


            
            txtID.Text = GenerarID();
            txtID.ReadOnly = true;

            cmbDuracion.Items.Clear();
            cmbDuracion.Items.AddRange(new string[]
            {
                "1MES", "2MES", "3MES", "4MES", "5MES", "6MES", "7MES", "10MES", "14MES", "20MES"
            });

            txtID.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtITBIS.ReadOnly = true;



        }
        private void GenerarNombreTour()
        {
            string pais = cmbPais.SelectedItem?.ToString() ?? "";
            string duracion = cmbDuracion.Text.Trim();
            var destinos = clbDestino.CheckedItems.Cast<string>().ToList();

            if (string.IsNullOrEmpty(pais) || string.IsNullOrEmpty(duracion) || destinos.Count == 0)
            {
                txtNombreTour.Text = "";
                return;
            }

            string destinosTexto = string.Join(", ", destinos);
            txtNombreTour.Text = $"{pais} - {duracion} - {destinosTexto}";
        }


        private string GenerarID()
        {
            int maxID = 0;

            if (File.Exists("tours_nuevo.csv"))
            {
                var lineas = File.ReadAllLines("tours_nuevo.csv");

                foreach (var linea in lineas)
                {
                    if (string.IsNullOrWhiteSpace(linea)) continue;

                    var partes = linea.Split(',');

                    if (partes.Length > 0 && int.TryParse(partes[0], out int id))
                    {
                        if (id > maxID)
                            maxID = id;
                    }
                }
            }

            return (maxID + 1).ToString("D4");
        }

        private void cmbPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paisSeleccionado = cmbPais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(paisSeleccionado)) return;

            clbDestino.Items.Clear();

            if (destinosPorPais.ContainsKey(paisSeleccionado))
            {
                clbDestino.Items.AddRange(destinosPorPais[paisSeleccionado].ToArray());
            }

            ActualizarPrecio(0);
            GenerarNombreTour();

        }

        private void clbDestino_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                List<string> destinosSeleccionados = clbDestino.CheckedItems.Cast<string>().ToList();

                // Simular el cambio que está por ocurrir
                string itemActual = clbDestino.Items[e.Index].ToString();
                if (e.NewValue == CheckState.Checked && !destinosSeleccionados.Contains(itemActual))
                    destinosSeleccionados.Add(itemActual);
                else if (e.NewValue == CheckState.Unchecked && destinosSeleccionados.Contains(itemActual))
                    destinosSeleccionados.Remove(itemActual);

                ActualizarPrecio(destinosSeleccionados.Count);
                GenerarNombreTour();
            });


        }
        private void ActualizarPrecio()
        {
            int cantidadCiudades = clbDestino.CheckedItems.Count;
            ActualizarPrecio(cantidadCiudades);
        }
        private void ActualizarPrecio(int cantidadCiudades)
        {
            string pais = cmbPais.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(pais)) return;
            if (!preciosBasePorPais.ContainsKey(pais)) return;

            decimal precioBase = preciosBasePorPais[pais];

            // Ajuste por cantidad de destinos
            if (cantidadCiudades == 1)
                precioBase *= 0.60m;
            else if (cantidadCiudades == 2)
                precioBase *= 1.70m;
            else if (cantidadCiudades >= 3)
                precioBase *= 2.00m;

            // Ajuste por duración del viaje
            decimal multiplicador = 1.0m;
            string duracionTexto = cmbDuracion.Text.Trim();

            if (duracionTexto.EndsWith("MES"))
            {
                string mesesStr = duracionTexto.Replace("MES", "");
                if (int.TryParse(mesesStr, out int meses))
                {
                    if (meses <= 2) multiplicador = 1.0m;
                    else if (meses <= 5) multiplicador = 1.5m;
                    else if (meses <= 10) multiplicador = 2.0m;
                    else multiplicador = 2.5m;
                }
            }

            decimal precioFinal = precioBase * multiplicador;
            txtPrecio.Text = precioFinal.ToString("0.00");

            decimal itbis = precioFinal * 0.18m;
            txtITBIS.Text = itbis.ToString("0.00");



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNombreTour.Text == "" || cmbPais.SelectedIndex == -1 || clbDestino.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idNuevo = txtID.Text.Trim();

            if (File.Exists("tours_nuevo.csv"))
            {
                var lineas = File.ReadAllLines("tours_nuevo.csv");
                bool idExistente = lineas.Any(l => l.StartsWith(idNuevo + ","));
                if (idExistente)
                {
                    MessageBox.Show("El ID ya está registrado en el sistema.");
                    return;
                }
            }

            string nombreTour = txtNombreTour.Text.Trim();
            string pais = cmbPais.SelectedItem.ToString();
            List<string> destinos = clbDestino.CheckedItems.Cast<string>().ToList();
            string destinosSeleccionados = string.Join(" | ", destinos);
            string duracion = cmbDuracion.Text.Trim();

            decimal precio;
            if (!Decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio inválido.");
                return;
            }

            decimal itbis = precio * 0.18m;
            txtITBIS.Text = itbis.ToString("0.00");

            string estado = "Vigente";
            string fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            string ruta = "tours_nuevos.csv";


            string nuevaLinea = $"{idNuevo};{nombreTour};{pais};{destinosSeleccionados};{duracion};{precio:0.00};{itbis:0.00};{estado};{fecha}";
            File.AppendAllText("tours_nuevo.csv", nuevaLinea + Environment.NewLine);
            FormMostrar frmMostrar = new FormMostrar();
            frmMostrar.CargarTours();
            frmMostrar.StartPosition = FormStartPosition.CenterScreen;
            frmMostrar.Show();

            
            MessageBox.Show("Tour guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Text = GenerarID();
            btnLimpiar.PerformClick();

            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreTour.Text = "";
            cmbPais.SelectedIndex = -1;
            clbDestino.Items.Clear();
            txtPrecio.Text = "";
            txtITBIS.Text = "";
            cmbDuracion.Text = "";
            lblEstado.Text = "Automatico";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDuracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPrecio(0);
            GenerarNombreTour();

        }

        
    }
}