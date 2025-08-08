namespace Agencia_de_tour
{
    partial class FormActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizar));
            btnActualizar = new Button();
            btnLimpiar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblEstado = new Label();
            cmbDuracion = new ComboBox();
            lblDestino = new Label();
            lblPais = new Label();
            lblID = new Label();
            lBLDuraccion = new Label();
            lBLITBIS = new Label();
            lblPrecio = new Label();
            lbl = new Label();
            clbDestino = new CheckedListBox();
            txtID = new TextBox();
            txtNombreTour = new TextBox();
            txtITBIS = new TextBox();
            txtPrecio = new TextBox();
            cmbPais = new ComboBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Silver;
            btnActualizar.Location = new Point(410, 513);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(211, 94);
            btnActualizar.TabIndex = 60;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LimeGreen;
            btnLimpiar.Location = new Point(675, 513);
            btnLimpiar.Margin = new Padding(1);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(213, 94);
            btnLimpiar.TabIndex = 62;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 79;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(-22, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 67);
            label1.TabIndex = 78;
            label1.Text = "Tour del Mar";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(234, 235);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 30);
            lblEstado.TabIndex = 77;
            lblEstado.Text = "Estado";
            // 
            // cmbDuracion
            // 
            cmbDuracion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(301, 420);
            cmbDuracion.Margin = new Padding(2);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(237, 28);
            cmbDuracion.TabIndex = 76;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(710, 282);
            lblDestino.Margin = new Padding(2, 0, 2, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(81, 30);
            lblDestino.TabIndex = 75;
            lblDestino.Text = "Destinos";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.Location = new Point(782, 201);
            lblPais.Margin = new Padding(2, 0, 2, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(53, 36);
            lblPais.TabIndex = 74;
            lblPais.Text = "Pais";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(250, 199);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 36);
            lblID.TabIndex = 73;
            lblID.Text = "ID";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLDuraccion.Location = new Point(197, 421);
            lBLDuraccion.Margin = new Padding(2, 0, 2, 0);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(85, 30);
            lBLDuraccion.TabIndex = 72;
            lBLDuraccion.Text = "Duracion";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLITBIS.Location = new Point(231, 348);
            lBLITBIS.Margin = new Padding(2, 0, 2, 0);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(54, 30);
            lBLITBIS.TabIndex = 71;
            lBLITBIS.Text = "ITBIS";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(234, 280);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(62, 30);
            lblPrecio.TabIndex = 70;
            lblPrecio.Text = "Precio";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(225, 132);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(151, 30);
            lbl.TabIndex = 69;
            lbl.Text = "Nombre de Tour ";
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(816, 272);
            clbDestino.Margin = new Padding(2);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(289, 158);
            clbDestino.TabIndex = 68;
            // 
            // txtID
            // 
            txtID.Location = new Point(301, 199);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(86, 27);
            txtID.TabIndex = 67;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(380, 128);
            txtNombreTour.Margin = new Padding(2);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.ReadOnly = true;
            txtNombreTour.Size = new Size(796, 27);
            txtNombreTour.TabIndex = 66;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(301, 348);
            txtITBIS.Margin = new Padding(2);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(141, 27);
            txtITBIS.TabIndex = 65;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(301, 276);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(124, 27);
            txtPrecio.TabIndex = 64;
            // 
            // cmbPais
            // 
            cmbPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(854, 202);
            cmbPais.Margin = new Padding(2);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(251, 28);
            cmbPais.TabIndex = 63;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.LightGray;
            btnBuscar.Location = new Point(410, 197);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 80;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1321, 766);
            Controls.Add(btnBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
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
            Controls.Add(btnLimpiar);
            Controls.Add(btnActualizar);
            Name = "FormActualizar";
            Text = "FormActualizar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnActualizar;
        private Button btnLimpiar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblEstado;
        private ComboBox cmbDuracion;
        private Label lblDestino;
        private Label lblPais;
        private Label lblID;
        private Label lBLDuraccion;
        private Label lBLITBIS;
        private Label lblPrecio;
        private Label lbl;
        private CheckedListBox clbDestino;
        private TextBox txtID;
        private TextBox txtNombreTour;
        private TextBox txtITBIS;
        private TextBox txtPrecio;
        private ComboBox cmbPais;
        private Button btnBuscar;
    }
}