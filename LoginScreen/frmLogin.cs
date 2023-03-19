using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace LoginScreen
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistrador telaRegistro = new FormRegistrador();

            telaRegistro.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lucaspessoli");
        }
    }
}
