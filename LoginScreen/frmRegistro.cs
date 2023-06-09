﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
using System.Diagnostics;

namespace LoginScreen
{
    public partial class FormRegistrador : Form
    {
        //Conexão com o banco de dados
        MySqlConnection conexao = new MySqlConnection("server=localhost;database=;uid=;pwd=;");
        Thread t;
        public FormRegistrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                    MySqlCommand inserir = new MySqlCommand("INSERT INTO registro (username, password, email) VALUES (@username, @password, @email);", conexao);
                    inserir.Parameters.AddWithValue("@username", txtusuario.Text);
                    inserir.Parameters.AddWithValue("@password", txtSenhaa.Text);
                    inserir.Parameters.AddWithValue("@email", txtEmaill.Text);
                    conexao.Open();
                    MySqlDataReader resultado1 = inserir.ExecuteReader();
                    conexao.Close();
                    MessageBox.Show("Conta criada com sucesso! Obrigado.", "Parabéns!");
                    frmLogin Login = new frmLogin();
                    Login.Show();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Este usuário ou e-mail já estão cadastrados!", "Erro");   
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
