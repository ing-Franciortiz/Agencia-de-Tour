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
            txtID.Location = new Point(412, 118);
            txtID.Margin = new Padding(8, 7, 8, 7);
            txtID.Name = "txtID";
            txtID.Size = new Size(306, 55);
            txtID.TabIndex = 0;
            // 
            // btnIDEliminar
            // 
            btnIDEliminar.Location = new Point(412, 211);
            btnIDEliminar.Margin = new Padding(8, 7, 8, 7);
            btnIDEliminar.Name = "btnIDEliminar";
            btnIDEliminar.Size = new Size(235, 70);
            btnIDEliminar.TabIndex = 1;
            btnIDEliminar.Text = "Eliminar Tour";
            btnIDEliminar.UseVisualStyleBackColor = true;
            btnIDEliminar.Click += btnIDEliminar_Click;
            // 
            // lblIDEliminar
            // 
            lblIDEliminar.AutoSize = true;
            lblIDEliminar.Location = new Point(412, 43);
            lblIDEliminar.Margin = new Padding(8, 0, 8, 0);
            lblIDEliminar.Name = "lblIDEliminar";
            lblIDEliminar.Size = new Size(521, 48);
            lblIDEliminar.TabIndex = 2;
            lblIDEliminar.Text = "Ingrese el ID del tour a eliminar";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(911, 135);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(115, 48);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // Form1Elininar
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2000, 1080);
            Controls.Add(lblResultado);
            Controls.Add(lblIDEliminar);
            Controls.Add(btnIDEliminar);
            Controls.Add(txtID);
            Margin = new Padding(8, 7, 8, 7);
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