namespace Agencia_de_tour
{
    partial class FormSalir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSalir));
            btnNo = new Button();
            btnSi = new Button();
            lblMensaje = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(520, 229);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(79, 48);
            btnNo.TabIndex = 5;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnSi
            // 
            btnSi.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSi.Location = new Point(364, 229);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(78, 48);
            btnSi.TabIndex = 4;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = true;
            btnSi.Click += btnSi_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.Location = new Point(293, 175);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(383, 38);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "¿Deseas cerrar el programa?";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(9, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 67);
            label1.TabIndex = 30;
            label1.Text = "Tour del Mar";
            // 
            // FormSalir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(793, 457);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblMensaje);
            Name = "FormSalir";
            Text = "FormSalir";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNo;
        private Button btnSi;
        private Label lblMensaje;
        private PictureBox pictureBox1;
        private Label label1;
    }
}