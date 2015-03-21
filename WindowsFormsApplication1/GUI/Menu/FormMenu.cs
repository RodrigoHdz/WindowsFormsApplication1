using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Catalogos;

namespace WindowsFormsApplication1.GUI.Menu
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_pventa_Click(object sender, EventArgs e)
        {
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            FormProductos Ventana = new FormProductos();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            FormClientes Ventana = new FormClientes();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            FormsAlmacen Ventana = new FormsAlmacen();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }

        private void btn_proveedores_Click(object sender, EventArgs e)
        {
            FormsProveedores Ventana = new FormsProveedores();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }

        private void btn_sucursales_Click(object sender, EventArgs e)
        {
            FormsSucursales Ventana = new FormsSucursales();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            FormsUsuarios Ventana = new FormsUsuarios();

            Ventana.ShowDialog();

            Ventana.Dispose();
        }
    }
}
