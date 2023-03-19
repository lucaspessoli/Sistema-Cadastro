using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Diagnostics;

namespace LoginScreen
{
    public partial class FormRegistrador : Form
    {
        //Conexão com o banco de dados
        MySqlConnection conexao = new MySqlConnection("Server=localhost;Database=;Uid=;Pwd=;");
        Thread t;
        public FormRegistrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "" || txtusuario.Text == " " || txtSenhaa.Text == "" || txtSenhaa.Text == " " || txtEmaill.Text == "" || txtEmaill.Text == " ")
            {
                MessageBox.Show("Erro! Insira credenciais corretas!");
            }
            else
            {
                MySqlCommand tabela = new MySqlCommand("CREATE TABLE IF NOT EXISTS registro(userid INT AUTO_INCREMENT PRIMARY KEY, username varchar(40) UNIQUE, password varchar(440), email varchar(704) UNIQUE);", conexao);
                conexao.Open();
                MySqlDataReader resultado = tabela.ExecuteReader();
                conexao.Close();
                Console.WriteLine("INSERT INTO registro (username, password, email) VALUES (" + "'" + 4 + "', " + "'" + 3 + "', " + "'" + 2 + "')");
                MySqlCommand inserir = new MySqlCommand("INSERT INTO registro (username, password, email) VALUES ("+"'"+txtusuario.Text+"', "+ "'"+txtSenhaa.Text+"', "+"'"+txtEmaill.Text +"');", conexao);
                conexao.Open();
                MySqlDataReader resultado1 = inserir.ExecuteReader();
                conexao.Close();            
            }
            }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmaill_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin telaLogin = new frmLogin();
            telaLogin.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/lucaspessoli");
        }
    }
    }
