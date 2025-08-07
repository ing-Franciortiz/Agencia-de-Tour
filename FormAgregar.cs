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
       
        private FormMostrar formMostrar;

        public FormAgregar(FormMostrar formMostrar)
        {
            InitializeComponent();
            this.formMostrar = formMostrar;
            this.Load += FormAgregar_Load;
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
            this.Load += FormAgregar_Load;
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {

            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;

            cmbPais.Items.Clear();
            cmbPais.Items.AddRange(destinosPorPais.Keys.ToArray());



            string idNuevo = GenerarID();
            txtID.Text = idNuevo;




            cmbDuracion.Items.Clear();
            cmbDuracion.Items.AddRange(new string[]
            {
            "1MESS", "2MESES", "3MESES", "4MESES", "5MESES", "6MESES", "7MESES", "8MESES", "9MESES", "10MESES", "11MESES", "12MESES"
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
            int nuevoID = 1;

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                var idsExistentes = lineas
                    .Select(l => l.Split(';')[0])
                    .Where(id => int.TryParse(id, out _))
                    .Select(id => int.Parse(id))
                    .ToList();

                if (idsExistentes.Any())
                {
                    nuevoID = idsExistentes.Max() + 1;
                }
            }

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

            ActualizarPrecioYITBIS();
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
            else
                precioBase = 0; // Si no hay destinos, no hay precio

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

        private void ActualizarPrecioYITBIS()
        {
            if (cmbPais.SelectedItem == null || cmbDuracion.SelectedItem == null)
                return;

            string pais = cmbPais.SelectedItem.ToString();
            string duracion = cmbDuracion.SelectedItem.ToString();

            decimal precioBase = 0;

            if (preciosBasePorPais.TryGetValue(pais, out precioBase))
            {
                int meses = 1;

                // Extraer los dígitos del inicio de la cadena de duración
                string numeroMeses = new string(duracion.TakeWhile(char.IsDigit).ToArray());
                int.TryParse(numeroMeses, out meses);

                decimal precioTotal = precioBase * meses;
                decimal itbis = precioTotal * 0.18m;

                txtPrecio.Text = precioTotal.ToString("0.00");
                txtITBIS.Text = itbis.ToString("0.00");
            }
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


            string nuevaLinea = $"{idNuevo};{nombreTour};{pais};{destinosSeleccionados};{duracion};{precio:0.00};{itbis:0.00};{estado};{DateTime.Now.ToString("dd/MM/yyyy hh:mm tt")}";
            File.AppendAllText("tours_nuevo.csv", nuevaLinea + Environment.NewLine);
            FormMostrar frmMostrar = new FormMostrar();
            frmMostrar.CargarTours();
            frmMostrar.StartPosition = FormStartPosition.CenterScreen;
            frmMostrar.Show();



            MessageBox.Show("Tour guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            btnLimpiar.PerformClick();
            txtID.Text = GenerarID();

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

            GenerarNombreTour();
            ActualizarPrecioYITBIS();
        }

     
       

    }
}

