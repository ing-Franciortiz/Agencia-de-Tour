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

      
    }
}
