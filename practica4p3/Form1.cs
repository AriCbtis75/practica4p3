using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica4p3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int valor1 = int.Parse(textBoxIngresar.Text);

                int resCua;
                int resCu;


                resCua = valor1 * valor1;
                resCu = valor1 * valor1 * valor1;


                if (valor1 > 0)
                {
                    textBoxCuadrado.Text = resCua.ToString();
                    textBoxCubo.Text = resCu.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Ingresa Valor Valido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Ingresa Valor Valido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
