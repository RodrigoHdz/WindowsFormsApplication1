using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class formCalculadora : Form
    {
        //Propiedades de la clase
        double numero1, numero2, resultado;

        public formCalculadora()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                if (numericUpDown2.Value == 0)
                {
                    btnSuma.Enabled = false;
                }
                else
                {
                    btnSuma.Enabled = true;
                }
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            //Obtener los datos
            numero1 = (double) numericUpDown1.Value;
            numero2 = Convert.ToDouble (numericUpDown2.Value);
            
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    resultado = numero1 + numero2;
                    break;
                case 1:
                    resultado = numero1 - numero2;
                    break;
                case 2:
                    resultado = numero1 * numero2;
                    break;
                case 3:
                    resultado = numero1 / numero2;
                    break;
            }

            MessageBox.Show("El resultado es: " + resultado);
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 3)
            {
                if(numericUpDown2.Value == 0)
                {
                    btnSuma.Enabled = false;
                }
            }
            else
            {
                btnSuma.Enabled = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }


    }
}
