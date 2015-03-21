using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.DB;
using WindowsFormsApplication1.GUI.Menu;

namespace WindowsFormsApplication1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Revisar si el usuario esta registrado
        public void REVISA_USUARIO_REGISTRADO()
        {

        }

        public bool VERIFICA_USUARIO_PASSWORD()
        {
            bool validar = true;

            //Validar que el usuario no sea "blanco" (this.txt_usuario.Text.Trim() == "")
            if(string.IsNullOrEmpty(this.txt_usuario.Text.Trim()))
            {
                MessageBox.Show("Ingrese un nombre de Usuario");
                validar = false;
                return validar;
            }

            //Validar que la contraseña no sea "blanco" (this.txt_password.Text.Trim() == "")
            if (string.IsNullOrEmpty(this.txt_password.Text.Trim()))
            {
                MessageBox.Show("Ingrese una contraseña");
                validar = false;
                return validar;
            }

            //CREAR EL OBJETO QUE ME CONECTA A LA BASE DE DATOS...
            ConexionMYSQL objetoODBC = new ConexionMYSQL();

            //CREAMOS LA SENTENCIA SQL QUE ME DEVUELVE LOS DATOS QUE CONCUERDAN CON LA CONDICION "WHERE"
            string SentenciaSQL;
            SentenciaSQL = "select usuario from sys_usuarios where usuario= '" + txt_usuario.Text + "' and contrasenia = '" + txt_password.Text + "'";
            
            //VALIDAR QUE LA COMBINACION DE USUARIO Y CONTRASEÑA EXISTA
            if (!objetoODBC.MYSQL_EXISTE_DATO(SentenciaSQL))
            {
                //SI NO EXISTE ESA COMBINACION, LOS DATOS SON INCORRECTOS
                MessageBox.Show("DATOS DE ACCESO INCORRECTOS!", "ERROR");
                validar = false;
                return validar;
            }

            return validar;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(this.VERIFICA_USUARIO_PASSWORD())
            {
                this.Hide();
                
                MessageBox.Show("Accesando al menu principal");

                FormMenu Ventana = new FormMenu();

                Ventana.ShowDialog();

            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
             * if(e.KeyChar == 13)
            {
            }
             */

            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("No se permite espacios");
                e.Handled = true;
            }
        }

        private void btn_nuevousuario_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario Ventana = new frmNuevoUsuario();
            Ventana.ShowDialog();
            Ventana.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
