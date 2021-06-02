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
            foreach (var item in lista)
            {
                listBox2.Items.Add(item.ToString());
            }
        }
    }
}
