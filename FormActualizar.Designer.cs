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
            dtpFecha = new DateTimePicker();
            btnBuscar = new Button();
            btnActualizar = new Button();
            lblFecha = new Label();
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
            SuspendLayout();
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(437, 41);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(282, 27);
            dtpFecha.TabIndex = 62;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(250, 82);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 61;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveBorder;
            btnActualizar.Location = new Point(172, 332);
            btnActualizar.Margin = new Padding(2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 30);
            btnActualizar.TabIndex = 60;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(157, 271);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 20);
            lblFecha.TabIndex = 59;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(613, 178);
            lblEstado.Margin = new Padding(2, 0, 2, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(66, 30);
            lblEstado.TabIndex = 58;
            lblEstado.Text = "Estado";
            // 
            // cmbDuracion
            // 
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(190, 276);
            cmbDuracion.Margin = new Padding(2);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(130, 28);
            cmbDuracion.TabIndex = 57;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(343, 243);
            lblDestino.Margin = new Padding(2, 0, 2, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(81, 30);
            lblDestino.TabIndex = 56;
            lblDestino.Text = "Destinos";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.Location = new Point(349, 178);
            lblPais.Margin = new Padding(2, 0, 2, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(53, 36);
            lblPais.TabIndex = 55;
            lblPais.Text = "Pais";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(172, 26);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(36, 36);
            lblID.TabIndex = 54;
            lblID.Text = "ID";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLDuraccion.Location = new Point(101, 277);
            lBLDuraccion.Margin = new Padding(2, 0, 2, 0);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(85, 30);
            lBLDuraccion.TabIndex = 53;
            lBLDuraccion.Text = "Duracion";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLITBIS.Location = new Point(127, 232);
            lBLITBIS.Margin = new Padding(2, 0, 2, 0);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(54, 30);
            lBLITBIS.TabIndex = 52;
            lBLITBIS.Text = "ITBIS";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(127, 184);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(62, 30);
            lblPrecio.TabIndex = 51;
            lblPrecio.Text = "Precio";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(22, 131);
            lbl.Margin = new Padding(2, 0, 2, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(151, 30);
            lbl.TabIndex = 50;
            lbl.Text = "Nombre de Tour ";
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(439, 243);
            clbDestino.Margin = new Padding(2);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(174, 70);
            clbDestino.TabIndex = 49;
            // 
            // txtID
            // 
            txtID.Location = new Point(234, 28);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(86, 27);
            txtID.TabIndex = 48;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(172, 126);
            txtNombreTour.Margin = new Padding(2);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(372, 27);
            txtNombreTour.TabIndex = 47;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(185, 228);
            txtITBIS.Margin = new Padding(2);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(65, 27);
            txtITBIS.TabIndex = 46;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(193, 183);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(81, 27);
            txtPrecio.TabIndex = 45;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(416, 180);
            cmbPais.Margin = new Padding(2);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(159, 28);
            cmbPais.TabIndex = 44;
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFecha);
            Controls.Add(btnBuscar);
            Controls.Add(btnActualizar);
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
            Name = "FormActualizar";
            Text = "FormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFecha;
        private Button btnBuscar;
        private Button btnActualizar;
        private Label lblFecha;
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
    }
}