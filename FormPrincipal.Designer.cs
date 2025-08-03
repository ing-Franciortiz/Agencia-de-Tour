namespace Agencia_de_tour
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mostrarToToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            actualizarToursToolStripMenuItem = new ToolStripMenuItem();
            eliminarTourToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Honeydew;
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mostrarToToolStripMenuItem, agregarToolStripMenuItem, actualizarToursToolStripMenuItem, eliminarTourToolStripMenuItem, exportarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(770, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mostrarToToolStripMenuItem
            // 
            mostrarToToolStripMenuItem.Name = "mostrarToToolStripMenuItem";
            mostrarToToolStripMenuItem.Size = new Size(111, 24);
            mostrarToToolStripMenuItem.Text = "Mostrar tours";
            mostrarToToolStripMenuItem.Click += mostrarToToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(110, 24);
            agregarToolStripMenuItem.Text = "Agregar Tour";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // actualizarToursToolStripMenuItem
            // 
            actualizarToursToolStripMenuItem.Name = "actualizarToursToolStripMenuItem";
            actualizarToursToolStripMenuItem.Size = new Size(128, 24);
            actualizarToursToolStripMenuItem.Text = "Actualizar Tours";
            actualizarToursToolStripMenuItem.Click += actualizarToursToolStripMenuItem_Click;
            // 
            // eliminarTourToolStripMenuItem
            // 
            eliminarTourToolStripMenuItem.Name = "eliminarTourToolStripMenuItem";
            eliminarTourToolStripMenuItem.Size = new Size(110, 24);
            eliminarTourToolStripMenuItem.Text = "Eliminar Tour";
            eliminarTourToolStripMenuItem.Click += eliminarTourToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(116, 24);
            exportarToolStripMenuItem.Text = "Exportar tours";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(770, 440);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Desktop;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "FormPrincipal";
            Text = "Agencia de Tour";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem eliminarTourToolStripMenuItem;
        private ToolStripMenuItem mostrarToToolStripMenuItem;
        private ToolStripMenuItem actualizarToursToolStripMenuItem;
    }
}
