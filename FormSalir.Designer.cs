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
            btnNo = new Button();
            btnSi = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.Location = new Point(158, 52);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 5;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // btnSi
            // 
            btnSi.Location = new Point(31, 52);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(94, 29);
            btnSi.TabIndex = 4;
            btnSi.Text = "SI";
            btnSi.UseVisualStyleBackColor = true;
            btnSi.Click += btnSi_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(41, 19);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(198, 20);
            lblMensaje.TabIndex = 3;
            lblMensaje.Text = "¿Deseas cerrar el programa?";
            lblMensaje.Click += lblMensaje_Click;
            // 
            // FormSalir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 114);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblMensaje);
            Name = "FormSalir";
            Text = "FormSalir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNo;
        private Button btnSi;
        private Label lblMensaje;
    }
}