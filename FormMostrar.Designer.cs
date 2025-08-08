namespace Agencia_de_tour
{
    partial class FormMostrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMostrar));
            tourBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Pais = new DataGridViewTextBoxColumn();
            Destino = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            ITBS = new DataGridViewTextBoxColumn();
            Duracion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tourBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Pais, Destino, Precio, ITBS, Duracion, Estado, Fecha });
            dataGridView1.Location = new Point(10, 128);
            dataGridView1.Margin = new Padding(1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 123;
            dataGridView1.Size = new Size(1396, 412);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 15;
            ID.Name = "ID";
            ID.Width = 300;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Tour";
            Nombre.MinimumWidth = 15;
            Nombre.Name = "Nombre";
            Nombre.Width = 300;
            // 
            // Pais
            // 
            Pais.HeaderText = "Pais";
            Pais.MinimumWidth = 15;
            Pais.Name = "Pais";
            Pais.Width = 300;
            // 
            // Destino
            // 
            Destino.HeaderText = "Destino";
            Destino.MinimumWidth = 15;
            Destino.Name = "Destino";
            Destino.Width = 300;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 15;
            Precio.Name = "Precio";
            Precio.Width = 300;
            // 
            // ITBS
            // 
            ITBS.HeaderText = "ITBS";
            ITBS.MinimumWidth = 15;
            ITBS.Name = "ITBS";
            ITBS.Width = 300;
            // 
            // Duracion
            // 
            Duracion.HeaderText = "Duracion";
            Duracion.MinimumWidth = 15;
            Duracion.Name = "Duracion";
            Duracion.Width = 300;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 15;
            Estado.Name = "Estado";
            Estado.Width = 300;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 15;
            Fecha.Name = "Fecha";
            Fecha.Width = 300;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(737, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(10, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(740, 67);
            label1.TabIndex = 28;
            label1.Text = "Bienbenidos al Tour del Mar";
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1924, 1055);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(1);
            Name = "FormMostrar";
            Text = "Mostrar Tour ";
            ((System.ComponentModel.ISupportInitialize)tourBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource tourBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Pais;
        private DataGridViewTextBoxColumn Destino;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn ITBS;
        private DataGridViewTextBoxColumn Duracion;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Fecha;
        private PictureBox pictureBox1;
        private Label label1;
    }
}