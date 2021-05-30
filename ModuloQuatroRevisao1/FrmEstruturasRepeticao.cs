﻿using System;
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
            for (int i = 0; i <= 10; i++)
            {
               
                ListViewItem itmx = listView1.Items.Add(iValorLido.ToString());
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "*"));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, i.ToString()));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, "="));
                itmx.SubItems.Add(new ListViewItem.ListViewSubItem(null, (iValorLido * i).ToString()));
            }

        }
        private void FrmEstruturasRepeticao_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            //valor1 sinal valor 2 = resultado
            listView1.Columns.Insert(0, "Valor", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(1, "Sinal", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(2, "Valor", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(3, "Igual", 50, HorizontalAlignment.Center);
            listView1.Columns.Insert(04, "Resultado", 70, HorizontalAlignment.Center);
            
        }
    }
}