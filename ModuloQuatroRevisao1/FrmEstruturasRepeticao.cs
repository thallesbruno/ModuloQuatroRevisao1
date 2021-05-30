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
        public FrmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        /*Estruturas de repeticaÓ
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


        }
        private void FrmEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            //valor1 sinal vallor 2 = resultado
            listView1.Columns.Insert(0, "Valor", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, "Sinal", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, "Valor", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, "Igual", 100, HorizontalAlignment.Center);
            listView1.Columns.Insert(04, "Resultado", 100, HorizontalAlignment.Center);
            
        }
    }
}
