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
            FormAgregar agregar = new FormAgregar();
            agregar.MdiParent = this;
            agregar.Show();

            foreach (Form f in this.MdiChildren)
            {
                if (f is FormAgregar)
                {
                    f.BringToFront();
                    return;
                }
            }
        }

        private List<Tour> _listaTours = new List<Tour>();
        private void eliminarTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1Elininar formEliminar = new Form1Elininar(_listaTours);
            formEliminar.ShowDialog();
        }

        private void actualizarToursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario de actualización, pasándole la lista de tours.
            FormActualizarTour formActualizar = new FormActualizarTour(_listaTours);
            // Muestra el formulario como un diálogo modal.
            // Esto significa que el usuario debe cerrar este formulario antes de interactuar con el principal.
            formActualizar.ShowDialog();
        }

       
    }
}
