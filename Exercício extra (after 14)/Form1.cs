namespace Exercício_extra__after_14_
{
    public partial class Form1 : Form
    {
        public Form1()
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
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CenasForms.Fechar();
        }
    }
}