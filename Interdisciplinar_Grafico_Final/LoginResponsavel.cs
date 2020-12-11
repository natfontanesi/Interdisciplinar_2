using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Interdisciplinar_Grafico_Final
{
    public partial class LoginResponsavel : Form
    {
        public LoginResponsavel()
        {
            InitializeComponent();
        }
        public NpgsqlConnection conn;
        string connString = @"Host=127.0.0.1;Username=postgres;Password=dkcn09242627;Database=Projeto_Interdisciplinar";
        public NpgsqlCommand cmd;
        public string selecao = null;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio Inicio = new Inicio();
            Inicio.Show();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Digite Usuário e Senha!");
                txtUser.Focus();
                return;
            }
            try
            {

                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                selecao = @"select * from u_loginResponsavel(:_usuario,:_senha)";
                cmd = new NpgsqlCommand(selecao, conn);


                cmd.Parameters.AddWithValue("_usuario", txtUser.Text);
                cmd.Parameters.AddWithValue("_senha", txtSenha.Text);

                int resultado = (int)cmd.ExecuteScalar();

                conn.Close();



                if (resultado == 1)
                {

                    Form1 planilhaResponsavel = new Form1();
                    planilhaResponsavel.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Nome ou senha estão incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Npgsql.PostgresException erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.Append(erro.Statement);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());
                

            }
            //tratamento dos demais erros que podem ocorrer

            catch (Exception erro)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(erro.GetType().ToString());
                sb.AppendLine(erro.Message);
                sb.AppendLine("\n");
                sb.AppendLine(erro.StackTrace);
                MessageBox.Show(sb.ToString());

            }

        }

        private void LoginResponsavel_Load(object sender, EventArgs e)
        {

        }
    }
    
}
