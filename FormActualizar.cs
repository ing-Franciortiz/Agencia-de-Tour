using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agencia_de_tour
{

    public partial class FormActualizar : Form
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

        private FormMostrar formMostrar;

        public FormActualizar(FormMostrar formMostrar)
        {
            InitializeComponent();
            this.formMostrar = formMostrar;
            InicializarControles(); // ✅ Inicializar todo
        }

        public FormActualizar()
        {
            InitializeComponent();
            InicializarControles(); // ✅ Inicializar todo
        }

        private void InicializarControles()
        {
            clbDestino.ItemCheck += clbDestino_ItemCheck;
            txtID.MaxLength = 5;
            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;

            cmbPais.Items.Clear();
            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());

            cmbDuracion.Items.Clear();
            cmbDuracion.Items.AddRange(new string[]
            {
                "1MES", "2MESES", "3MESES", "4MESES", "5MESES", "6MESES", "7MESES", "8MESES", "9MESES", "10MESES", "11MESES", "12MESES"
            });

            txtPrecio.ReadOnly = true;
            txtITBIS.ReadOnly = true;
        }



        private void CargarDatosTour(string tourData)
        {
            var partes = tourData.Split(';');
            if (partes.Length < 9)
            {
                MessageBox.Show("Los datos del tour están incompletos.");
                return;
            }

            // ID y nombre
            txtID.Text = partes[0];
            txtNombreTour.Text = partes[1];

            // País y destinos
            string pais = partes[2];
            string[] destinos = partes[3].Split('|');

            cmbPais.SelectedIndex = cmbPais.Items.IndexOf(pais);

            clbDestino.Items.Clear();
            if (destinosPorPais.ContainsKey(pais))
            {
                clbDestino.Items.AddRange(destinosPorPais[pais].ToArray());
                for (int i = 0; i < clbDestino.Items.Count; i++)
                {
                    if (destinos.Contains(clbDestino.Items[i].ToString()))
                    {
                        clbDestino.SetItemChecked(i, true);
                    }
                }
            }

            // Duración
            cmbDuracion.SelectedItem = partes[4];

            // Precio e ITBIS
            txtPrecio.Text = partes[5];
            txtITBIS.Text = partes[6];

            // Estado
            lblEstado.Text = partes[7];

            // Fecha
            if (DateTime.TryParse(partes[8], out DateTime fecha))
            {
                dtpFecha.Value = fecha;
            }
            else
            {
                dtpFecha.Value = DateTime.Today;
            }
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

            ActualizarPrecioYITBIS_Actualizar();
            GenerarNombreTour();
        }

        private void clbDestino_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                List<string> destinosSeleccionados = clbDestino.CheckedItems.Cast<string>().ToList();

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

            if (cantidadCiudades == 1)
                precioBase *= 0.60m;
            else if (cantidadCiudades == 2)
                precioBase *= 1.70m;
            else if (cantidadCiudades >= 3)
                precioBase *= 2.00m;

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


        private void ActualizarPrecioYITBIS_Actualizar()
        {
            if (cmbPais.SelectedItem == null || cmbDuracion.SelectedItem == null)
                return;

            string pais = cmbPais.SelectedItem.ToString();
            string duracion = cmbDuracion.SelectedItem.ToString();

            Dictionary<string, decimal> preciosBasePorPais = new Dictionary<string, decimal>()
    {
        { "República Dominicana", 2500m },
        { "México", 2200m },
        { "Colombia", 2000m }
    };

            if (preciosBasePorPais.TryGetValue(pais, out decimal precioBase))
            {
                int meses = ObtenerCantidadMeses(duracion);
                decimal precioTotal = precioBase * meses;
                decimal itbis = precioTotal * 0.18m;

                txtPrecio.Text = precioTotal.ToString("0.00");
                txtITBIS.Text = itbis.ToString("0.00");
            }
        }





        private int ObtenerCantidadMeses(string duracion)
        {
            duracion = duracion.ToUpper().Trim();

            for (int i = 1; i <= 12; i++)
            {
                if (duracion == $"{i}MES" || duracion == $"{i}MESES")
                {
                    return i;
                }
            }

            return 1; // Por defecto
        }





        private void cmbDuracion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarPrecioYITBIS_Actualizar();
            GenerarNombreTour();
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



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblEstado_Click(object sender, EventArgs e) { }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Esto puedes dejarlo vacío o eliminarlo si no lo usas
        }


        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string idBuscado = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(idBuscado))
            {
                MessageBox.Show("Por favor, ingrese un ID para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (File.Exists("tours_nuevo.csv"))
            {
                var lineas = File.ReadAllLines("tours_nuevo.csv");
                var tourEncontrado = lineas.FirstOrDefault(l => l.StartsWith(idBuscado + ";"));

                if (tourEncontrado != null)
                {
                    CargarDatosTour(tourEncontrado);
                }
                else
                {
                    MessageBox.Show("No se encontró un tour con ese ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("El archivo tours_nuevo.csv no existe.");
            }
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string nombre = txtNombreTour.Text.Trim();
            string pais = cmbPais.SelectedItem?.ToString() ?? "";
            string duracion = cmbDuracion.SelectedItem?.ToString() ?? "";
            string precio = txtPrecio.Text.Trim();
            string itbis = txtITBIS.Text.Trim();
            string estado = lblEstado.Text.Trim();
            string fecha = dtpFecha.Value.ToShortDateString();

            var destinosSeleccionados = clbDestino.CheckedItems.Cast<string>().ToList();
            string destinos = string.Join("|", destinosSeleccionados);

            // Validación mínima
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pais) ||
                string.IsNullOrEmpty(duracion) || destinosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios antes de actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ruta = "tours_nuevo.csv";
            if (!File.Exists(ruta))
            {
                MessageBox.Show("El archivo de tours no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lineas = File.ReadAllLines(ruta).ToList();
            int indice = lineas.FindIndex(l => l.StartsWith(id + ";"));

            if (indice == -1)
            {
                MessageBox.Show("No se encontró el tour con ese ID para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Reemplazar línea correcta
            string nuevaLinea = $"{id};{nombre};{pais};{destinos};{duracion};{precio};{itbis};{estado};{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}";
            lineas[indice] = nuevaLinea;

            File.WriteAllLines(ruta, lineas);
            MessageBox.Show("Tour actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
}






















