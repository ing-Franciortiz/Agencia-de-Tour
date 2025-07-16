namespace Agencia_de_tour
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        
        private void agregarTourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.MdiParent = this; // ⬅ Esto lo ancla dentro del contenedor principal
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
    }
}
