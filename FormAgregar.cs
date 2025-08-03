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
        public class Tour
        {
            public int ID { get; set; }
            public string Nombre { get; set; }
            // otros campos...
        }
        private FormMostrar formMostrar;

        public FormAgregar(FormMostrar formMostrar)
        {
            InitializeComponent();
            this.formMostrar = formMostrar;
        }
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
            txtID.MaxLength = 5;
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;

            cmbPais.Items.Clear();
            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());



            txtID.Text = GenerarID();
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



            cmbDuracion.Items.Clear();
            cmbDuracion.Items.AddRange(new string[]
            {
            "1MES", "2MES", "3MES", "4MES", "5MES", "6MES", "7MES", "10MES", "14MES", "20MES"
            });


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
            string ruta = "tours_nuevo.csv";
            int maxID = 0;

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                foreach (var linea in lineas)
                {
                    var partes = linea.Split(';');
                    if (partes.Length > 0 && int.TryParse(partes[0], out int idActual))
                    {
                        if (idActual > maxID)
                            maxID = idActual;
                    }
                }
            }

            int nuevoID = maxID + 1;
            return nuevoID.ToString("D4"); // Ejemplo: "0002"
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

            string idNuevo = txtID.Text.Trim(); // toma lo que el usuario escribió (aunque esté mal)

            if (string.IsNullOrWhiteSpace(idNuevo))
            {
                MessageBox.Show("El ID no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar si ya existe el ID
            if (File.Exists("tours_nuevo.csv"))
            {
                var lineas = File.ReadAllLines("tours_nuevo.csv");

                bool idExistente = lineas.Any(l => l.Split(';')[0] == idNuevo);

                if (idExistente)
                {
                    MessageBox.Show($"El ID '{idNuevo}' ya está registrado. Por favor, genera uno nuevo.", "ID duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            if (txtID.Text == "" || txtNombreTour.Text == "" || txtNombreTour.Text == "" || cmbPais.SelectedIndex == -1 || clbDestino.CheckedItems.Count == 0)
            {
                MessageBox.Show("Por favor completa todos los campos requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



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
            string nombreDetalle = txtNombreTour.Text.Trim();
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
            
            
            btnLimpiar.PerformClick();

            if (string.IsNullOrWhiteSpace(idNuevo))
            {
                MessageBox.Show("El ID no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar si ya existe el ID
          


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreTour.Text = "";
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo de tours";
            saveFileDialog.FileName = "tours_exportados.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string sourceFilePath = "tours_nuevo.csv";

                    if (File.Exists(sourceFilePath))
                    {

                        string destinationFilePath = saveFileDialog.FileName;

                        File.Copy(sourceFilePath, destinationFilePath, true);
                        MessageBox.Show($"Archivo exportado correctamente a: {destinationFilePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El archivo de tours ('tours_nuevo.csv') no existe en la carpeta de la aplicación para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al exportar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreTour_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        
        {
            // Permitir solo números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquear la tecla
            }
        }


    }
}
