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
    public partial class FrmEstruturasRepeticao : Form
    {
        private List<int> lista = new List<int>();
        public FrmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        /*Estruturas de repeticao
         * PRE TESTADA - while
         * POS TESTADA - do while
         * VARIAVEL DE CONTROLE - for
         * SEM NUMERO DE REPETICOES PRE DEFINIDO - for each
         */

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Deve ser informado um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }
            int iValorLido = Convert.ToInt32(textBox1.Text.Trim());
            listView1.Items.Clear();
            /*for (int i = 0; i <= 10; i++)
            {
               
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
            }*/
            /*int i = 0;
            while (i <= 10)
            {
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
                i++;
            }*/
            int i = 0;
            do
            {
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
                i++;
            } while (i <= 10);

            //Trabalhando com vetores

            /* int[] vetor = new int[] {10, 20, 30, 40, 50};
            int iPrimeiroValor = vetor[0];
            int soma = 0;
            int index = 0;
            

            /*vetor[0] = 1;
            vetor[1] = 10;
            vetor[2] = 20;*/

            /*for (index = 0; index < 10; index++)
            {
                soma = soma + vetor[index];
            }*/

            /*index = 0;
            while (index < 10)
            {
                soma = soma + vetor[index];
                index++;
            }

            index = 0;
            do
            {
                soma = soma + vetor[index];
                index++;
            } while (index < 10);*/

            //Trabalhando com matrizes
            int[,] matriz = new int[,] { {10, 10, 10} , {25, 30, 40} };
            /*matriz[0, 0] = 10;
            matriz[0, 1] = 20;*/
            int soma = 0;

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    soma = matriz[linha, coluna];
                }
            }
            MessageBox.Show("Valor da soma: " + soma, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            //valor1 sinal valor 2 = resultado
            listView1.Columns.Insert(0, "Valor", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, "Sinal", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, "Valor", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, "Igual", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(4, "Resultado", 70, HorizontalAlignment.Center);

            /*for (int i = 0; i < 100; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }*/
            int i = 0;
            while (i <= 100)
            {
                comboBox1.Items.Add(i.ToString());
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(String.Empty))
            {
                MessageBox.Show("Deve ser informado um valor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }
            lista.Add(Convert.ToInt32(textBox2.Text.Trim()));
            listBox1.Items.Add(textBox2.Text.Trim());
            textBox2.Text = String.Empty;
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (String item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
