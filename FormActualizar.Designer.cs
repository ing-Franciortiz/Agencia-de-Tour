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
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(917, 228);
            btnBuscar.Margin = new Padding(8, 7, 8, 7);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(235, 70);
            btnBuscar.TabIndex = 61;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = SystemColors.ActiveBorder;
            btnActualizar.Location = new Point(430, 797);
            btnActualizar.Margin = new Padding(5);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(225, 72);
            btnActualizar.TabIndex = 60;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(392, 650);
            lblFecha.Margin = new Padding(5, 0, 5, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 48);
            lblFecha.TabIndex = 59;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(1532, 427);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(152, 70);
            lblEstado.TabIndex = 58;
            lblEstado.Text = "Estado";
            // 
            // cmbDuracion
            // 
            cmbDuracion.FormattingEnabled = true;
            cmbDuracion.Location = new Point(475, 662);
            cmbDuracion.Margin = new Padding(5);
            cmbDuracion.Name = "cmbDuracion";
            cmbDuracion.Size = new Size(319, 56);
            cmbDuracion.TabIndex = 57;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDestino.Location = new Point(858, 583);
            lblDestino.Margin = new Padding(5, 0, 5, 0);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(188, 70);
            lblDestino.TabIndex = 56;
            lblDestino.Text = "Destinos";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPais.Location = new Point(872, 427);
            lblPais.Margin = new Padding(5, 0, 5, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(127, 85);
            lblPais.TabIndex = 55;
            lblPais.Text = "Pais";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Myanmar Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(531, 213);
            lblID.Margin = new Padding(5, 0, 5, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(87, 85);
            lblID.TabIndex = 54;
            lblID.Text = "ID";
            // 
            // lBLDuraccion
            // 
            lBLDuraccion.AutoSize = true;
            lBLDuraccion.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLDuraccion.Location = new Point(252, 665);
            lBLDuraccion.Margin = new Padding(5, 0, 5, 0);
            lBLDuraccion.Name = "lBLDuraccion";
            lBLDuraccion.Size = new Size(198, 70);
            lBLDuraccion.TabIndex = 53;
            lBLDuraccion.Text = "Duracion";
            // 
            // lBLITBIS
            // 
            lBLITBIS.AutoSize = true;
            lBLITBIS.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lBLITBIS.Location = new Point(318, 557);
            lBLITBIS.Margin = new Padding(5, 0, 5, 0);
            lBLITBIS.Name = "lBLITBIS";
            lBLITBIS.Size = new Size(124, 70);
            lBLITBIS.TabIndex = 52;
            lBLITBIS.Text = "ITBIS";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(318, 442);
            lblPrecio.Margin = new Padding(5, 0, 5, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(145, 70);
            lblPrecio.TabIndex = 51;
            lblPrecio.Text = "Precio";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Myanmar Text", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(45, 344);
            lbl.Margin = new Padding(5, 0, 5, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(347, 70);
            lbl.TabIndex = 50;
            lbl.Text = "Nombre de Tour ";
            // 
            // clbDestino
            // 
            clbDestino.FormattingEnabled = true;
            clbDestino.Location = new Point(1098, 583);
            clbDestino.Margin = new Padding(5);
            clbDestino.Name = "clbDestino";
            clbDestino.Size = new Size(429, 274);
            clbDestino.TabIndex = 49;
            // 
            // txtID
            // 
            txtID.Location = new Point(663, 236);
            txtID.Margin = new Padding(5);
            txtID.Name = "txtID";
            txtID.RightToLeft = RightToLeft.No;
            txtID.Size = new Size(209, 55);
            txtID.TabIndex = 48;
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(430, 344);
            txtNombreTour.Margin = new Padding(5);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(924, 55);
            txtNombreTour.TabIndex = 47;
            // 
            // txtITBIS
            // 
            txtITBIS.Location = new Point(462, 547);
            txtITBIS.Margin = new Padding(5);
            txtITBIS.Name = "txtITBIS";
            txtITBIS.Size = new Size(156, 55);
            txtITBIS.TabIndex = 46;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(482, 439);
            txtPrecio.Margin = new Padding(5);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(196, 55);
            txtPrecio.TabIndex = 45;
            // 
            // cmbPais
            // 
            cmbPais.FormattingEnabled = true;
            cmbPais.Location = new Point(1040, 432);
            cmbPais.Margin = new Padding(5);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(392, 56);
            cmbPais.TabIndex = 44;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.AppWorkspace;
            btnLimpiar.Location = new Point(702, 800);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(225, 69);
            btnLimpiar.TabIndex = 62;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormActualizar
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1080);
            Controls.Add(btnLimpiar);
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
            Margin = new Padding(8, 7, 8, 7);
            Name = "FormActualizar";
            Text = "FormActualizar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button btnLimpiar;
    }
}