namespace Agencia_de_tour
{
    partial class FormAgregar
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
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnCancelar = new Button();
            cmbPais = new ComboBox();
            txtPrecio = new TextBox();
            txtITBIS = new TextBox();
            txtNombreTour = new TextBox();
            txtID = new TextBox();
            clbDestino = new CheckedListBox();
            lbl = new Label();
            lblPrecio = new Label();
            lBLITBIS = new Label();
            lBLDuraccion = new Label();
            lblID = new Label();
            lblPais = new Label();
            lblDestino = new Label();
            cmbDuracion = new ComboBox();
            lblEstado = new Label();
            lblFecha = new Label();
            btnExportar = new Button();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 355);
            btnGuardar.Margin = new Padding(1);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 29);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar Tour";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(318, 355);
            btnLimpiar.Margin = new Padding(1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 29);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(528, 330);
            btnCancelar.Margin = new Padding(1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 29);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(318, 81);
            cmbPais.Margin = new Padding(1);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(186, 28);
            cmbPais.TabIndex = 3;
            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            cmbPais.Click += cmbPais_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(6, 74);
            txtPrecio.Margin = new Padding(1);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(92, 27);
            txtPrecio.TabIndex = 6;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(6, 132);
            txtITBIS.Margin = new Padding(1);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(75, 27);
            txtITBIS.TabIndex = 7;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(10, 29);
            txtNombreTour.Margin = new Padding(1);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(423, 27);
            txtNombreTour.TabIndex = 10;
            txtNombreTour.TextChanged += txtNombreTour_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(6, 236);
            txtID.Margin = new Padding(1);
            txtID.Name = "txtID";
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(99, 27);
            txtID.TabIndex = 11;
            txtID.TextChanged += txtID_TextChanged;
            txtID.KeyPress += txtID_KeyPress;
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(567, 67);
            clbDestino.Margin = new Padding(1);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(197, 26);
            clbDestino.TabIndex = 12;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(6, -3);
            lbl.Margin = new Padding(1, 0, 1, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(122, 20);
            lbl.TabIndex = 13;
            lbl.Text = "Nombre de Tour ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(6, 52);
            lblPrecio.Margin = new Padding(1, 0, 1, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(50, 20);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Location = new Point(6, 107);
            lBLITBIS.Margin = new Padding(1, 0, 1, 0);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(42, 20);
            lBLITBIS.TabIndex = 15;
            lBLITBIS.Text = "ITBIS";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Location = new Point(6, 166);
            lBLDuraccion.Margin = new Padding(1, 0, 1, 0);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(69, 20);
            lBLDuraccion.TabIndex = 16;
            lBLDuraccion.Text = "Duracion";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(6, 215);
            lblID.Margin = new Padding(1, 0, 1, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(24, 20);
            lblID.TabIndex = 17;
            lblID.Text = "ID";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(318, 59);
            lblPais.Margin = new Padding(1, 0, 1, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(34, 20);
            lblPais.TabIndex = 19;
            lblPais.Text = "Pais";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(635, 29);
            lblDestino.Margin = new Padding(1, 0, 1, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(66, 20);
            lblDestino.TabIndex = 20;
            lblDestino.Text = "Destinos";
            lblDestino.Click += lblDestino_Click;
            // 
            // cmbDuracion
            // 
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(8, 191);
            cmbDuracion.Margin = new Padding(1);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(148, 28);
            cmbDuracion.TabIndex = 22;
            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(6, 279);
            lblEstado.Margin = new Padding(1, 0, 1, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(54, 20);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "Estado";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(510, 154);
            lblFecha.Margin = new Padding(1, 0, 1, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 24;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(452, 215);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 25;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(880, 424);
            Controls.Add(btnExportar);
            Controls.Add(lblFecha);
            Controls.Add(lblEstado);
            Controls.Add(cmbDuracion);
            Controls.Add(lblDestino);
            Controls.Add(lblPais);
            Controls.Add(lblID);
            Controls.Add(lBLDuraccion);
            Controls.Add(lBLITBIS);
            Controls.Add(lblPrecio);
            Controls.Add(lbl);
            Controls.Add(clbDestino);
            Controls.Add(txtID);
            Controls.Add(txtNombreTour);
            Controls.Add(txtITBIS);
            Controls.Add(txtPrecio);
            Controls.Add(cmbPais);
            Controls.Add(btnCancelar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Margin = new Padding(1);
            Name = "FormAgregar";
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnCancelar;
        private ComboBox cmbPais;
        private TextBox txtPrecio;
        private TextBox txtITBIS;
        private TextBox txtNombreTour;
        private TextBox txtID;
        private CheckedListBox clbDestino;
        private Label lbl;
        private Label lblPrecio;
        private Label lBLITBIS;
        private Label lBLDuraccion;
        private Label lblID;
        private Label lblPais;
        private Label lblDestino;
        private ComboBox cmbDuracion;
        private Label lblEstado;
        private Label lblFecha;
        private Button btnExportar;
    }
}