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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean result1 = textBox1.Text.Trim().Equals(String.Empty);
            Boolean result2 = textBox2.Text.Trim().Equals(String.Empty);

            if (result1 == true || result2 == true)
            {
                MessageBox.Show("Insira todos os valores.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int numero1, numero2;

            //numero1 = Convert.ToInt32(textBox1.Text.Trim());
            numero1 = int.Parse(textBox1.Text.Trim());
            numero2 = Convert.ToInt32(textBox2.Text.Trim());

            /*
             * > maior
             * < menor
             * == igual
             * >= maior ou igual
             * <= menor ou igual
             */

            if (numero1 == numero2)
            {
                MessageBox.Show("Os valores são iguais!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (numero1 > numero2)
            {
                MessageBox.Show("Primeiro valor é maior!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Segundo valor é maior!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // operador "ou" "or"
            if (txtSenha.Text.Trim().Equals(String.Empty) || txtSenha.Text.Trim().Length <= 3)
            {
                MessageBox.Show("Senha inválida!");
            }

            // operador "e" "and"
            if (txtSenha.Text.Trim().Length > 3 && !txtSenha.Text.Trim().Equals("admin"))
            {
                MessageBox.Show("Senha válida!");
            }
            else
            {
                MessageBox.Show("Senha inválida!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDiaSemana.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Informe o dia da semana", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int iDia = Convert.ToInt32(txtDiaSemana.Text.Trim());
            switch (iDia)
            {
                case 1:
                    MessageBox.Show("Domingo");
                    break;
                case 2:
                    MessageBox.Show("Segunda");
                    break;
                case 3:
                    MessageBox.Show("Terça");
                    break;
                case 4:
                    MessageBox.Show("Quarta");
                    break;
                case 5:
                    MessageBox.Show("Quinta");
                    break;
                case 6:
                    MessageBox.Show("Sexta");
                    break;
                case 7:
                    MessageBox.Show("Sábado");
                    break;
                default:
                    MessageBox.Show("Dia não reconhecido");
                    break;
            }
        }
    }
}
