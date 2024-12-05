using System;
using System.Threading;
using System.Windows.Forms;

namespace Semana_13_DemoPatronProductorConsumidor
{//ejemplo para clonar con contraseña jajaja my name is eysonnnnnn ni
    public partial class FormCafeteria : Form
    {
        private int contadorId = 1; // Contador para asignar IDs únicos
        private ClsBarra<ClsProducto> barraProductos; // Cola que almacena los productos
        private ClsBarista barista; // Productor
        private ClsCliente cliente; // Consumidor

        public FormCafeteria()
        {
            InitializeComponent();

            // Inicializar la barra (cola) con capacidad de 10 productos
            barraProductos = new ClsBarra<ClsProducto>(10);

            // Inicializar barista y cliente
            barista = new ClsBarista(barraProductos);
            cliente = new ClsCliente(barraProductos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPreparar_Click(object sender, EventArgs e)
        {
            ClsProducto nuevoProducto = new ClsProducto(
                contadorId++,
                txtProducto.Text
            );

            // Iniciar la preparación en un hilo
            ThreadPool.QueueUserWorkItem(state =>
            {
                barraProductos.Agregar(nuevoProducto);
            });

            txtProducto.Clear();
        }

        private void btnRecoger_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarProducto);
            hiloConsumidor.Start();
        }

        private void ProcesarProducto()
        {
            ClsProducto producto = barraProductos.Extraer();
            AgregarProductoAGrid(producto);
        }

        private void AgregarProductoAGrid(ClsProducto producto)
        {
            if (dgvBarra.InvokeRequired)
            {
                dgvBarra.Invoke(new Action(() =>
                {
                    dgvBarra.Rows.Add(
                        producto.Id,
                        producto.Nombre,
                        producto.HoraPreparacion
                    );
                }));
            }
            else
            {
                dgvBarra.Rows.Add(
                    producto.Id,
                    producto.Nombre,
                    producto.HoraPreparacion
                );
            }
        }

        private void FormCafeteria_Load(object sender, EventArgs e)
        {

        }
    }
}
