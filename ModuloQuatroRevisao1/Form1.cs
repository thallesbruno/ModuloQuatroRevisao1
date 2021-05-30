using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloQuatroRevisao1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            * + ==> soma
            * - ==> subtracao
            * * ==> multiplicacao
            * / ==> divisao 
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean result1 = textBox1.Text.Trim().Equals(String.Empty);
            Boolean result2 = textBox2.Text.Trim().Equals(String.Empty);

            if (result1 == true || result2 == true){
                MessageBox.Show("Insira todos os valores.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int numero1, numero2;

            //numero1 = Convert.ToInt32(textBox1.Text.Trim());
            numero1 = int.Parse(textBox1.Text.Trim());
            numero2 = Convert.ToInt32(textBox2.Text.Trim());
            
            /*
                double var10 = 10.50;            
                int var11 = Convert.ToInt32(var10);
                decimal var12 = Convert.ToDecimal(var10);
                decimal var13 = Decimal.Parse("15.80");
                float var14 = float.Parse("15.80");
            */

            label5.Text = (numero1 + numero2).ToString();
            label6.Text = (numero1 - numero2).ToString();
            label7.Text = (numero1 * numero2).ToString();
            label8.Text = (numero1 / numero2).ToString();
        }
    }
}
