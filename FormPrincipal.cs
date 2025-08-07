namespace Agencia_de_tour
{
    public partial class FormPrincipal : Form
    {
        private FormMostrar formMostrar;
        private bool eliminarAbierto = false;
        public FormPrincipal()
        {
            InitializeComponent();

            formMostrar = new FormMostrar();

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
            if (!eliminarAbierto)
            {
                FormMostrar ventanaMostrar = formMostrar; // Usa la instancia ya creada

                if (ventanaMostrar != null)
                {
                    Form1Elininar ventanaEliminar = new Form1Elininar(ventanaMostrar);
                    ventanaEliminar.MdiParent = this;
                    ventanaEliminar.FormClosed += (s, args) => eliminarAbierto = false; // Cuando se cierre
                    ventanaEliminar.Show();
                    eliminarAbierto = true; // Marcar que está abierto
                }
                else
                {
                    MessageBox.Show("Primero debes abrir el formulario de mostrar tours.");
                }
            }
            else
            {
                MessageBox.Show("La ventana de eliminación ya está abierta.");
            }


        }





        

        private void actualizarToursToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }



        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormSalir Salir = new FormSalir
            {
                MdiParent = this,
                StartPosition = FormStartPosition.Manual,
                WindowState = FormWindowState.Maximized
            };
            Salir.Show();
        }
    }
}
