using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            // 🔄 Ajuste automático de columnas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            CargarTours();

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
                else
                {
                    MessageBox.Show($"La línea tiene {partes.Length} campos, pero se esperaban {dataGridView1.Columns.Count}:\n{linea}");

                }
            }
        }
        

    }
}
