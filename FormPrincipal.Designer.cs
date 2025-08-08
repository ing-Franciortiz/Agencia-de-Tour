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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(48, 48);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mostrarToToolStripMenuItem, agregarToolStripMenuItem, actualizarToursToolStripMenuItem, eliminarTourToolStripMenuItem, exportarToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(2, 1, 0, 1);
            menuStrip1.Size = new Size(1133, 54);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mostrarToToolStripMenuItem
            // 
            mostrarToToolStripMenuItem.Image = (Image)resources.GetObject("mostrarToToolStripMenuItem.Image");
            mostrarToToolStripMenuItem.Name = "mostrarToToolStripMenuItem";
            mostrarToToolStripMenuItem.Size = new Size(159, 52);
            mostrarToToolStripMenuItem.Text = "Mostrar tours";
            mostrarToToolStripMenuItem.Click += mostrarToToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Image = (Image)resources.GetObject("agregarToolStripMenuItem.Image");
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(158, 52);
            agregarToolStripMenuItem.Text = "Agregar Tour";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // actualizarToursToolStripMenuItem
            // 
            actualizarToursToolStripMenuItem.Image = (Image)resources.GetObject("actualizarToursToolStripMenuItem.Image");
            actualizarToursToolStripMenuItem.Name = "actualizarToursToolStripMenuItem";
            actualizarToursToolStripMenuItem.Size = new Size(176, 52);
            actualizarToursToolStripMenuItem.Text = "Actualizar Tours";
            actualizarToursToolStripMenuItem.Click += actualizarToursToolStripMenuItem_Click;
            // 
            // eliminarTourToolStripMenuItem
            // 
            eliminarTourToolStripMenuItem.Image = (Image)resources.GetObject("eliminarTourToolStripMenuItem.Image");
            eliminarTourToolStripMenuItem.Name = "eliminarTourToolStripMenuItem";
            eliminarTourToolStripMenuItem.Size = new Size(158, 52);
            eliminarTourToolStripMenuItem.Text = "Eliminar Tour";
            eliminarTourToolStripMenuItem.Click += eliminarTourToolStripMenuItem_Click;
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Image = (Image)resources.GetObject("exportarToolStripMenuItem.Image");
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(164, 52);
            exportarToolStripMenuItem.Text = "Exportar tours";
            exportarToolStripMenuItem.Click += exportarToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Image = (Image)resources.GetObject("salirToolStripMenuItem.Image");
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(100, 52);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click_1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1133, 577);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Desktop;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(1);
            Name = "FormPrincipal";
            Text = "Agencia de Tour";
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
