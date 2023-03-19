using System;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace LoginScreen
{
    public partial class frmLogin : Form
    {
        string conexaoString = "server=localhost;database=;uid=;pwd=;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string conexaoString = "server=localhost;database=;uid=;pwd=;";
            String user = txtUsuarioLogin.Text;
            String senha = txtSenhaLogin.Text;
            MySqlConnection conexao = new MySqlConnection(conexaoString);

            String seleciona = ("SELECT COUNT(*) FROM registro WHERE username=@user AND password=@senha");
            MySqlCommand comando = new MySqlCommand(seleciona, conexao);
            comando.Parameters.AddWithValue("@user", user);
            comando.Parameters.AddWithValue("@senha", senha);
            conexao.Open();
            string res = comando.ExecuteScalar().ToString();
            conexao.Close();
            if (res != null && res =="1")
            {
                MessageBox.Show("Logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Insira as credenciais corretas, caso você não tenha uma conta crie uma através do botão: Criar uma Conta", "Conta inexistente!");
            }

        }
    }
}
