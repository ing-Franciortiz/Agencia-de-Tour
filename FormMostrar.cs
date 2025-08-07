using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Agencia_de_tour
{

    public partial class FormMostrar : Form
    {
        public FormMostrar()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre del Tour");
            dataGridView1.Columns.Add("Pais", "País");
            dataGridView1.Columns.Add("Destinos", "Destinos");
            dataGridView1.Columns.Add("Duracion", "Duración");
            dataGridView1.Columns.Add("Precio", "Precio");
            dataGridView1.Columns.Add("ITBIS", "ITBIS");
            dataGridView1.Columns.Add("Estado", "Estado");
            dataGridView1.Columns.Add("Fecha", "Fecha");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            CargarTours();
        }
        public DataGridView DataGridViewPrincipal => dataGridView1;
        public void RefrescarDatos()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists("tours_nuevo.csv")) return;

            var lineas = File.ReadAllLines("tours_nuevo.csv");
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length >= dataGridView1.Columns.Count)
                {
                    dataGridView1.Rows.Add(partes);
                }
            }
        }

        public void CargarTours()
        {
            dataGridView1.Rows.Clear();

            if (!File.Exists("tours_nuevo.csv")) return;

            var lineas = File.ReadAllLines("tours_nuevo.csv");
            foreach (var linea in lineas)
            {
                if (string.IsNullOrWhiteSpace(linea)) continue;

                var partes = linea.Split(';');
                if (partes.Length >= dataGridView1.Columns.Count)
                {
                    dataGridView1.Rows.Add(partes);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



