namespace Agencia_de_tour
{
    public partial class FormPrincipal : Form
    {
        private FormMostrar formMostrar;
        private bool eliminarAbierto = false;
        private FormActualizar formActualizar;
        private bool actualizarAbierto = false;

        public FormPrincipal()
        {
            InitializeComponent();
            formMostrar = new FormMostrar();
        }

        // Método reutilizable para mostrar formularios
        private void MostrarFormularioEnContenedor(Form formulario)
        {
            formulario.MdiParent = this;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.StartPosition = FormStartPosition.Manual;
            formulario.Show();
        }

        // Método genérico para verificar si ya está abierto
        private bool TraerAlFrenteSiExiste<T>() where T : Form
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is T)
                {
                    f.WindowState = FormWindowState.Maximized;
                    f.BringToFront();
                    return true;
                }
            }
            return false;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TraerAlFrenteSiExiste<FormAgregar>()) return;
            FormAgregar agregar = new FormAgregar();
            MostrarFormularioEnContenedor(agregar);
        }

        private void mostrarToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TraerAlFrenteSiExiste<FormMostrar>()) return;
            formMostrar = new FormMostrar();
            MostrarFormularioEnContenedor(formMostrar);
        }

        private void eliminarTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eliminarAbierto)
            {
                MessageBox.Show("La ventana de eliminación ya está abierta.");
                return;
            }

            if (formMostrar == null)
            {
                MessageBox.Show("Primero debes abrir el formulario de mostrar tours.");
                return;
            }

            Form1Elininar ventanaEliminar = new Form1Elininar(formMostrar);
            ventanaEliminar.FormClosed += (s, args) => eliminarAbierto = false;
            MostrarFormularioEnContenedor(ventanaEliminar);
            eliminarAbierto = true;
        }

        private void actualizarToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (actualizarAbierto)
            {
                formActualizar.Focus();
                return;
            }

            if (formMostrar == null)
            {
                MessageBox.Show("Primero debes abrir el formulario de mostrar tours.");
                return;
            }

            formActualizar = new FormActualizar(formMostrar);
            formActualizar.FormClosed += (s, args) => actualizarAbierto = false;
            MostrarFormularioEnContenedor(formActualizar);
            actualizarAbierto = true;
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMostrar == null)
            {
                MessageBox.Show("Primero debes abrir el formulario de mostrar tours.");
                return;
            }

            FormExportar formExportar = new FormExportar(formMostrar);
            MostrarFormularioEnContenedor(formExportar);
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (TraerAlFrenteSiExiste<FormSalir>()) return;
            FormSalir salir = new FormSalir();
            MostrarFormularioEnContenedor(salir);
        }
    }
}