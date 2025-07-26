namespace Agencia_de_tour
{
    partial class FormActualizarTour
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
            label1 = new Label();
            txtIdActualizar = new TextBox();
            btnBuscarTour = new Button();
            grpDatosTour = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            txtNombreTour = new TextBox();
            txtPaisDestino = new TextBox();
            btnGuardarCambios = new Button();
            txtDestino = new TextBox();
            txtPrecio = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpFechaTour = new DateTimePicker();
            dtpHoraTour = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtIdActualizar
            // 
            txtIdActualizar.Location = new Point(12, 2);
            txtIdActualizar.Name = "txtIdActualizar";
            txtIdActualizar.Size = new Size(125, 27);
            txtIdActualizar.TabIndex = 1;
            // 
            // btnBuscarTour
            // 
            btnBuscarTour.Location = new Point(143, 0);
            btnBuscarTour.Name = "btnBuscarTour";
            btnBuscarTour.Size = new Size(94, 29);
            btnBuscarTour.TabIndex = 2;
            btnBuscarTour.Text = "Buscar";
            btnBuscarTour.UseVisualStyleBackColor = true;
            // 
            // grpDatosTour
            // 
            grpDatosTour.Location = new Point(29, 157);
            grpDatosTour.Name = "grpDatosTour";
            grpDatosTour.Size = new Size(250, 125);
            grpDatosTour.TabIndex = 3;
            grpDatosTour.TabStop = false;
            grpDatosTour.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(481, 13);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 46);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // txtNombreTour
            // 
            txtNombreTour.Location = new Point(330, 6);
            txtNombreTour.Name = "txtNombreTour";
            txtNombreTour.Size = new Size(125, 27);
            txtNombreTour.TabIndex = 6;
            // 
            // txtPaisDestino
            // 
            txtPaisDestino.Location = new Point(330, 39);
            txtPaisDestino.Name = "txtPaisDestino";
            txtPaisDestino.Size = new Size(125, 27);
            txtPaisDestino.TabIndex = 7;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(143, 70);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(94, 29);
            btnGuardarCambios.TabIndex = 8;
            btnGuardarCambios.Text = "Guardar";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(330, 72);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(125, 27);
            txtDestino.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(330, 181);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 79);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 13;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(471, 118);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 14;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(471, 148);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(471, 188);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 16;
            label7.Text = "label7";
            // 
            // dtpFechaTour
            // 
            dtpFechaTour.Location = new Point(306, 255);
            dtpFechaTour.Name = "dtpFechaTour";
            dtpFechaTour.Size = new Size(250, 27);
            dtpFechaTour.TabIndex = 17;
            // 
            // dtpHoraTour
            // 
            dtpHoraTour.Location = new Point(293, 319);
            dtpHoraTour.Name = "dtpHoraTour";
            dtpHoraTour.Size = new Size(250, 27);
            dtpHoraTour.TabIndex = 18;
            // 
            // FormActualizarTour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpHoraTour);
            Controls.Add(dtpFechaTour);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(txtDestino);
            Controls.Add(btnGuardarCambios);
            Controls.Add(txtPaisDestino);
            Controls.Add(txtNombreTour);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grpDatosTour);
            Controls.Add(btnBuscarTour);
            Controls.Add(txtIdActualizar);
            Controls.Add(label1);
            Name = "FormActualizarTour";
            Text = "FormActualizarTour";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdActualizar;
        private Button btnBuscarTour;
        private GroupBox grpDatosTour;
        private Label label2;
        private Label label3;
        private TextBox txtNombreTour;
        private TextBox txtPaisDestino;
        private Button btnGuardarCambios;
        private TextBox txtDestino;
        private TextBox txtPrecio;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpFechaTour;
        private DateTimePicker dtpHoraTour;
    }
}