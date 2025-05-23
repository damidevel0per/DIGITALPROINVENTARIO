using CapaNegocio;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCapaNegocio = new CN_Productos();
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            CentrarPanel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CentrarPanel()
        {
            panelContenedor.Left = (this.ClientSize.Width - panelContenedor.Width) / 2;
            panelContenedor.Top = (this.ClientSize.Height - panelContenedor.Height) / 2;
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            ModalAgregarProductos objVentanaAgregarProductos = new ModalAgregarProductos();
            objVentanaAgregarProductos.Text = "Registrar producto";
            objVentanaAgregarProductos.ShowDialog();
            try
            {
                if (objVentanaAgregarProductos.DialogResult == DialogResult.OK)
                {
                    string nombre = objVentanaAgregarProductos.txtNombre.Text;
                    string descripcion = objVentanaAgregarProductos.txtDescripcion.Text;
                    string marca = objVentanaAgregarProductos.txtMarca.Text;
                    string precio = objVentanaAgregarProductos.txtPrecio.Text;
                    string stock = objVentanaAgregarProductos.txtStock.Text;
                    string url = objVentanaAgregarProductos.txtURLIMAGEN.Text;
                    objetoCapaNegocio.InsertarProductos(nombre, descripcion, marca, precio, stock, url);
                    MessageBox.Show("Operacion de registro de producto exitosa!");
                    ActualizarVistaProductos();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo registrar producto: {ex}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarVistaProductos();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            string idProducto = null;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                ModalAgregarProductos objVentanaEditarProductos = new ModalAgregarProductos();
                objVentanaEditarProductos.Text = "Editar producto";
                objVentanaEditarProductos.txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                objVentanaEditarProductos.txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                objVentanaEditarProductos.txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                objVentanaEditarProductos.txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                objVentanaEditarProductos.txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                objVentanaEditarProductos.txtURLIMAGEN.Text = dataGridView1.CurrentRow.Cells["ImagenUrl"].Value.ToString();
                try
                {
                    objVentanaEditarProductos.imagenURL.Load(dataGridView1.CurrentRow.Cells["ImagenUrl"].Value.ToString());
                }
                catch (Exception)
                {
                    objVentanaEditarProductos.imagenURL.Image = Properties.Resources.imagendefault;
                }

                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                objVentanaEditarProductos.ShowDialog();

                if (objVentanaEditarProductos.DialogResult == DialogResult.OK)
                {
                    string nombre = objVentanaEditarProductos.txtNombre.Text;
                    string descripcion = objVentanaEditarProductos.txtDescripcion.Text;
                    string marca = objVentanaEditarProductos.txtMarca.Text;
                    string precio = objVentanaEditarProductos.txtPrecio.Text;
                    string stock = objVentanaEditarProductos.txtStock.Text;
                    string url = objVentanaEditarProductos.txtURLIMAGEN.Text;
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCapaNegocio.EditarProductos(nombre, descripcion, marca, precio, stock, idProducto, url);
                    MessageBox.Show("Operacion de edicion de producto exitosa!");
                    ActualizarVistaProductos();
                }
            }
            else { MessageBox.Show("Seleccione una columna para editar!"); }

        }

        private void ActualizarVistaProductos()
        {
            CN_Productos objetoCN = new CN_Productos();
            dataGridView1.DataSource = objetoCN.MostrarProductos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string idProd;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProd = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objetoCapaNegocio.EliminarProductos(idProd);
                MessageBox.Show("Producto eliminado exitosamente!");
                ActualizarVistaProductos();
            }
            else { MessageBox.Show("Seleccione una columna para eliminar!"); }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DatosProducto objVentanaVerProductos = new DatosProducto();
                objVentanaVerProductos.lblNombreProducto.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                objVentanaVerProductos.txtDetalleProducto.Text =
                    $"Descripcion: {dataGridView1.CurrentRow.Cells["Descripcion"].Value}" + Environment.NewLine +
                    "" + Environment.NewLine +
                    $"Marca: {dataGridView1.CurrentRow.Cells["Marca"].Value}" + Environment.NewLine +
                    "" + Environment.NewLine +
                    $"Precio: ${dataGridView1.CurrentRow.Cells["Precio"].Value}" + Environment.NewLine +
                    "" + Environment.NewLine +
                    $"Stock: {dataGridView1.CurrentRow.Cells["Stock"].Value}";
                try
                {
                    objVentanaVerProductos.imagenURL.Load(dataGridView1.CurrentRow.Cells["ImagenUrl"].Value.ToString());
                }
                catch (Exception)
                {
                    objVentanaVerProductos.imagenURL.Image = Properties.Resources.imagendefault;
                }

                objVentanaVerProductos.Show();
            }
            else { MessageBox.Show("Seleccione una columna para eliminar!"); }

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }
    }
}
