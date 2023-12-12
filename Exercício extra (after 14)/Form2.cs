using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício_extra__after_14_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox3.PasswordChar = '●';
            label5.Text = Utilizador.Nome;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Utilizador.Nome = textBox1.Text;
            Utilizador.Email = textBox2.Text;
            Utilizador.Pass = textBox3.Text;
            MessageBox.Show("Login Efetuado com sucesso");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            label5.Text = Utilizador.Nome;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                textBox3.PasswordChar = '\0';
            else
                textBox3.PasswordChar = '●';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CenasForms.Fechar();
        }

    }
}
