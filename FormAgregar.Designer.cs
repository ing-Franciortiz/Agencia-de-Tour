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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAgregar));
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveBorder;
            btnGuardar.Location = new Point(308, 552);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(268, 96);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar Tour";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LimeGreen;
            btnLimpiar.Location = new Point(634, 552);
            btnLimpiar.Margin = new Padding(2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(289, 96);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Location = new Point(990, 552);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(263, 96);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(874, 180);
            cmbPais.Margin = new Padding(2);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(251, 33);
            cmbPais.TabIndex = 3;
            cmbPais.SelectedIndexChanged += cmbPais_SelectedIndexChanged;
            cmbPais.Click += cmbPais_SelectedIndexChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(321, 246);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(124, 34);
            txtPrecio.TabIndex = 6;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(321, 318);
            txtITBIS.Margin = new Padding(2);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(141, 34);
            txtITBIS.TabIndex = 7;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(400, 106);
            txtNombreTour.Margin = new Padding(2);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.ReadOnly = true;
            txtNombreTour.Size = new Size(796, 34);
            txtNombreTour.TabIndex = 10;
            txtNombreTour.TabStop = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(321, 177);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(86, 34);
            txtID.TabIndex = 11;
            txtID.TabStop = false;
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(836, 250);
            clbDestino.Margin = new Padding(2);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(322, 149);
            clbDestino.TabIndex = 12;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(245, 110);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(151, 30);
            lbl.TabIndex = 13;
            lbl.Text = "Nombre de Tour ";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(254, 250);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(62, 30);
            lblPrecio.TabIndex = 14;
            lblPrecio.Text = "Precio";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLITBIS.Location = new Point(251, 318);
            lBLITBIS.Margin = new Padding(2, 0, 2, 0);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(54, 30);
            lBLITBIS.TabIndex = 15;
            lBLITBIS.Text = "ITBIS";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLDuraccion.Location = new Point(217, 391);
            lBLDuraccion.Margin = new Padding(2, 0, 2, 0);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(85, 30);
            lBLDuraccion.TabIndex = 16;
            lBLDuraccion.Text = "Duracion";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(270, 177);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 36);
            lblID.TabIndex = 17;
            lblID.Text = "ID";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.Location = new Point(802, 179);
            lblPais.Margin = new Padding(2, 0, 2, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(53, 36);
            lblPais.TabIndex = 19;
            lblPais.Text = "Pais";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(730, 260);
            lblDestino.Margin = new Padding(2, 0, 2, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(81, 30);
            lblDestino.TabIndex = 20;
            lblDestino.Text = "Destinos";
            // 
            // cmbDuracion
            // 
            cmbDuracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(321, 390);
            cmbDuracion.Margin = new Padding(2);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(237, 33);
            cmbDuracion.TabIndex = 22;
            cmbDuracion.SelectedIndexChanged += cmbDuracion_SelectedIndexChanged;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(447, 183);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 30);
            lblEstado.TabIndex = 23;
            lblEstado.Text = "Estado";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(196, 299);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 25);
            lblFecha.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(-2, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 67);
            label1.TabIndex = 26;
            label1.Text = "Tour del Mar";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1924, 1003);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
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
            Font = new Font("Myanmar Text", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(2);
            Name = "FormAgregar";
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label1;
        private PictureBox pictureBox1;
    }
}