using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = txtComida.Text;
            comboBox1.Items.Add(x);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFecharPedido_Click(object sender, EventArgs e)
        {
            string msg = "Voce vai comer: ";
            msg += comboBox1.SelectedItem.ToString();
            msg += " e vai beber: " + lstBebidas.SelectedItem.ToString();
            bool praViagem = chkViagem.Checked;
            if (praViagem)
            {
                msg += "\nPra viagem";
            }
            MessageBox.Show(msg);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            
        }
    }
}
