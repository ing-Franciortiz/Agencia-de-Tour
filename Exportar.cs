using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic;

namespace Agencia_de_tour
{
    public partial class FormExportar : Form
    {
        private FormMostrar formMostrar;

        public FormExportar(FormMostrar mostrar)
        {
            formMostrar = mostrar;

            // Ajustes del formulario
            this.Text = "Exportar Tours";
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterParent;

            // Crear layout para los botones
            TableLayoutPanel layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(100),
                AutoSize = true
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(layout);

            // Botón para exportar por ID
            Button btnExportarPorID = new Button
            {
                Name = "btnExportarPorID",
                Text = "Exportar por ID",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Height = 100
            };
            btnExportarPorID.Click += btnExportarPorID_Click;
            layout.Controls.Add(btnExportarPorID, 0, 0);

            // Botón para exportar todo
            Button btnExportarTodo = new Button
            {
                Name = "btnExportarTodo",
                Text = "Exportar Todo",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Height = 100
            };
            btnExportarTodo.Click += btnExportarTodo_Click;
            layout.Controls.Add(btnExportarTodo, 1, 0);
        }

        private void btnExportarTodo_Click(object sender, EventArgs e)
        {
            ExportarTodos();
        }

        private void btnExportarPorID_Click(object sender, EventArgs e)
        {
            string id = Interaction.InputBox("Ingresa el ID del tour que deseas exportar:", "Exportar por ID", "");

            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("No se ingresó ningún ID.");
                return;
            }

            ExportarPorID(id.Trim());
        }

        private void ExportarTodos()
        {
            var dgv = formMostrar.DataGridViewPrincipal;

            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Exportar todos los tours",
                FileName = "todos_los_tours.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    var headers = dgv.Columns.Cast<DataGridViewColumn>();
                    writer.WriteLine(string.Join(";", headers.Select(h => h.HeaderText)));

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            writer.WriteLine(string.Join(";", cells.Select(c => c.Value?.ToString() ?? "")));
                        }
                    }
                }

                MessageBox.Show("Exportación completa.");
            }
        }

        private void ExportarPorID(string id)
        {
            var dgv = formMostrar.DataGridViewPrincipal;

            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                Title = "Exportar tour por ID",
                FileName = $"tour_{id}.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    var headers = dgv.Columns.Cast<DataGridViewColumn>();
                    writer.WriteLine(string.Join(";", headers.Select(h => h.HeaderText)));

                    bool encontrado = false;

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (!row.IsNewRow && row.Cells[0].Value?.ToString() == id)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            writer.WriteLine(string.Join(";", cells.Select(c => c.Value?.ToString() ?? "")));
                            encontrado = true;
                            break;
                        }
                    }

                    if (encontrado)
                    {
                        MessageBox.Show($"Tour con ID {id} exportado.");
                    }
                    else
                    {
                        MessageBox.Show($"No se encontró el ID {id}.");
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ClientSize = new Size(1616, 568);
            Name = "FormExportar";
            ResumeLayout(false);
        }
    }
}