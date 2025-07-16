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
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(287, 813);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(225, 69);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar Tour";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(688, 813);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 69);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1070, 813);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(225, 69);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(959, 203);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(459, 56);
            cmbPais.TabIndex = 3;
            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(180, 187);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(224, 55);
            txtPrecio.TabIndex = 6;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(180, 327);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(181, 55);
            txtITBIS.TabIndex = 7;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(180, 76);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(1238, 55);
            txtNombreTour.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Location = new Point(180, 577);
            txtID.Name = "txtID";
            txtID.Size = new Size(241, 55);
            txtID.TabIndex = 11;
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(1439, 142);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(469, 166);
            clbDestino.TabIndex = 12;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(180, 25);
            lbl.Name = "lbl";
            lbl.Size = new Size(281, 48);
            lbl.TabIndex = 13;
            lbl.Text = "Nombre de Tour";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(180, 134);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(119, 48);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Location = new Point(180, 266);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(99, 48);
            lBLITBIS.TabIndex = 15;
            lBLITBIS.Text = "ITBIS";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Location = new Point(180, 408);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(163, 48);
            lBLDuraccion.TabIndex = 16;
            lBLDuraccion.Text = "Duracion";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(180, 526);
            lblID.Name = "lblID";
            lblID.Size = new Size(55, 48);
            lblID.TabIndex = 17;
            lblID.Text = "ID";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(959, 152);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(81, 48);
            lblPais.TabIndex = 19;
            lblPais.Text = "Pais";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(1439, 79);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(156, 48);
            lblDestino.TabIndex = 20;
            lblDestino.Text = "Destinos";
            // 
            // cmbDuracion
            // 
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(184, 467);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(363, 56);
            cmbDuracion.TabIndex = 22;
            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(180, 680);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(125, 48);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "Estado";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(2131, 976);
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
    }
}