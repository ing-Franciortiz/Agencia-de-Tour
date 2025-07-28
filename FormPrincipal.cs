namespace Agencia_de_tour
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya está abierto
            foreach (Form f in this.MdiChildren)
            {
                if (f is FormAgregar)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.BringToFront();
                    return;
                }
            }

            // Crear y mostrar en pantalla completa
            FormAgregar agregar = new FormAgregar
            {
                MdiParent = this,
                StartPosition = FormStartPosition.Manual,
                WindowState = FormWindowState.Maximized
            };
            agregar.Show();


        }


        private void mostrarToToolStripMenuItem_Click(object sender, EventArgs e)
        {
               // Verifica si ya está abierto
    foreach (Form f in this.MdiChildren)
    {
        if (f is FormMostrar)
        {
            f.WindowState = FormWindowState.Maximized;
            f.BringToFront();
            return;
        }
    }

                    // Crear y mostrar en pantalla completa
            FormMostrar mostrar = new FormMostrar
            {
                 MdiParent = this,
                 StartPosition = FormStartPosition.Manual,
                 WindowState = FormWindowState.Maximized
            };
                 mostrar.Show();


        }

        private void eliminarTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1Elininar"] == null)
            {
                Form1Elininar ventanaEliminar = new Form1Elininar();
                ventanaEliminar.MdiParent = this; // 👈 Le dices que el padre es el actual formulario MDI
                ventanaEliminar.StartPosition = FormStartPosition.Manual;
                ventanaEliminar.Dock = DockStyle.Fill;
                ventanaEliminar.FormBorderStyle = FormBorderStyle.None;
                ventanaEliminar.Show();
            }
            else
            {
                Application.OpenForms["Form1Elininar"].BringToFront();
            }



        }
    }
}
