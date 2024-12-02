namespace Semana_13_DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        //variable para simular contador automatico de variable
        private int contadorId = 1;
        //elementos que vamos a trabajar
        private ClsCola<ClsUsuario> colaUsuarios;
        private ClsProductor productor;
        private ClsConsumidor consumidor;
        //cuando se inicia el formlario inicializan los componentes
        public Form1()
        {
            InitializeComponent();
            colaUsuarios = new ClsCola<ClsUsuario>(10);
            productor = new ClsProductor(colaUsuarios);
            consumidor = new ClsConsumidor(colaUsuarios);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ClsUsuario nuevoUsuario = new ClsUsuario(
                contadorId++,
                txtNombres.Text,
                txtCorreoElectronico.Text
                );
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);
                }
                );
            txtNombres.Clear();
            txtCorreoElectronico.Clear();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }
        private void ProcesarUsuario()
        {
            ClsUsuario usuario = colaUsuarios.Extraer();
            AgregarUsuarioDataGrid(usuario);
        }
        private void AgregarUsuarioDataGrid(ClsUsuario usuario)
        {
            if (dgvUsuarios.InvokeRequired)
            {
                dgvUsuarios.Invoke(new Action(() =>
                {
                    dgvUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
                })
                    );
            }
            else
            {
                dgvUsuarios.Rows.Add(
                        usuario.Id,
                        usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
