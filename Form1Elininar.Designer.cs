namespace Agencia_de_tour
{
    partial class Form1Elininar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Elininar));
            txtID = new TextBox();
            btnIDEliminar = new Button();
            lblIDEliminar = new Label();
            lblResultado = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(375, 178);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 34);
            txtID.TabIndex = 0;
            // 
            // btnIDEliminar
            // 
            btnIDEliminar.BackColor = Color.Red;
            btnIDEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIDEliminar.Location = new Point(520, 177);
            btnIDEliminar.Name = "btnIDEliminar";
            btnIDEliminar.Size = new Size(146, 37);
            btnIDEliminar.TabIndex = 1;
            btnIDEliminar.Text = "Eliminar Tour";
            btnIDEliminar.UseVisualStyleBackColor = false;
            btnIDEliminar.Click += btnIDEliminar_Click;
            // 
            // lblIDEliminar
            // 
            lblIDEliminar.AutoSize = true;
            lblIDEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDEliminar.Location = new Point(363, 135);
            lblIDEliminar.Name = "lblIDEliminar";
            lblIDEliminar.Size = new Size(313, 28);
            lblIDEliminar.TabIndex = 2;
            lblIDEliminar.Text = "Ingrese el ID del tour a eliminar";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(700, 187);
            lblResultado.Margin = new Padding(1, 0, 1, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 23);
            lblResultado.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 33);
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
            label1.Location = new Point(-2, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(356, 67);
            label1.TabIndex = 28;
            label1.Text = "Tour del Mar";
            // 
            // Form1Elininar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1201, 500);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(lblIDEliminar);
            Controls.Add(btnIDEliminar);
            Controls.Add(txtID);
            Name = "Form1Elininar";
            Text = "Form1Elininar";
            Load += Form1Elininar_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Button btnIDEliminar;
        private Label lblIDEliminar;
        private Label lblResultado;
        private PictureBox pictureBox1;
        private Label label1;
    }
}