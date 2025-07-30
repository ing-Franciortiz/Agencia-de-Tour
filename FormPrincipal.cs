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
                // Obtener el formulario de mostrar tours
                FormMostrar ventanaMostrar = Application.OpenForms
                    .OfType<FormMostrar>()
                    .FirstOrDefault();

                if (ventanaMostrar != null)
                {
                    Form1Elininar ventanaEliminar = new Form1Elininar(ventanaMostrar); // ← PASA LA REFERENCIA AQUÍ
                    ventanaEliminar.MdiParent = this;
                    ventanaEliminar.StartPosition = FormStartPosition.Manual;
                    ventanaEliminar.Dock = DockStyle.Fill;
                    ventanaEliminar.FormBorderStyle = FormBorderStyle.None;
                    ventanaEliminar.Show();
                }
                else
                {
                    MessageBox.Show("Primero debes abrir el formulario de mostrar tours.");
                }
            }
            else
            {
                Application.OpenForms["Form1Elininar"].BringToFront();
            }



        }
    }
}
