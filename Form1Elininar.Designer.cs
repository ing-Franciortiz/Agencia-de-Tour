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
            txtID = new TextBox();
            btnIDEliminar = new Button();
            lblIDEliminar = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(200, 11);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(110, 23);
            txtID.TabIndex = 0;
            // 
            // btnIDEliminar
            // 
            btnIDEliminar.BackColor = Color.Red;
            btnIDEliminar.Location = new Point(78, 42);
            btnIDEliminar.Margin = new Padding(3, 2, 3, 2);
            btnIDEliminar.Name = "btnIDEliminar";
            btnIDEliminar.Size = new Size(98, 28);
            btnIDEliminar.TabIndex = 1;
            btnIDEliminar.Text = "Eliminar Tour";
            btnIDEliminar.UseVisualStyleBackColor = false;
            btnIDEliminar.Click += btnIDEliminar_Click;
            // 
            // lblIDEliminar
            // 
            lblIDEliminar.AutoSize = true;
            lblIDEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIDEliminar.Location = new Point(12, 15);
            lblIDEliminar.Name = "lblIDEliminar";
            lblIDEliminar.Size = new Size(182, 15);
            lblIDEliminar.TabIndex = 2;
            lblIDEliminar.Text = "Ingrese el ID del tour a eliminar";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(200, 47);
            lblResultado.Margin = new Padding(1, 0, 1, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(45, 17);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // Form1Elininar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 244);
            Controls.Add(lblResultado);
            Controls.Add(lblIDEliminar);
            Controls.Add(btnIDEliminar);
            Controls.Add(txtID);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1Elininar";
            Text = "Form1Elininar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Button btnIDEliminar;
        private Label lblIDEliminar;
        private Label lblResultado;
    }
}