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
            txtIdEliminar = new TextBox();
            btnEliminarTour = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(121, 12);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(125, 27);
            txtIdEliminar.TabIndex = 0;
            // 
            // btnEliminarTour
            // 
            btnEliminarTour.Location = new Point(65, 60);
            btnEliminarTour.Name = "btnEliminarTour";
            btnEliminarTour.Size = new Size(94, 29);
            btnEliminarTour.TabIndex = 1;
            btnEliminarTour.Text = "button1";
            btnEliminarTour.UseVisualStyleBackColor = true;
            btnEliminarTour.Click += btnEliminarTour_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(158, 120);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(50, 20);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // Form1Elininar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnEliminarTour);
            Controls.Add(txtIdEliminar);
            Name = "Form1Elininar";
            Text = "Form1Elininar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdEliminar;
        private Button btnEliminarTour;
        private Label lblMensaje;
    }
}