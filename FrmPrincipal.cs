using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LISTA___MURILO_AUGUSTO_KRUGNER_ALMEIDA_LEITE
{
    public partial class FrmPrincipal : Form
    {
        List<string> list = new List<string>();
        Array pointer;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("Por favor, digite um valor para adicionar a lista");
                return;
            }

            list.Add(textBox.Text);

            pointer = list.ToArray();

            listView1.Items.Clear();

            foreach (string i in pointer)
            {
                listView1.Items.Add(i.ToString());

            }

            textBox.Clear();

            textBox.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                list.RemoveAt(0);
            } else
            {
                list.Remove(textBox.Text);
            }

            pointer = list.ToArray();

            listView1.Items.Clear();

            foreach (string i in pointer)
            {
                listView1.Items.Add(i.ToString());

            }

            textBox.Clear();

            textBox.Focus();
        }

        private void btnQnt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quantidade de items adicionados a lista: " + list.Count.ToString());

            textBox.Clear();

            textBox.Focus();
        }
    }
}
