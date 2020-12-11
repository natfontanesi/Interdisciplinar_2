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
    public partial class Relatorio2 : Form
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;
        public Relatorio2()
        {
            InitializeComponent();
        }

        private void Relatorio2_Load(object sender, EventArgs e)
        {
            try
            {
                //string de conexão com o banco de dados
                string connString = @"Host=127.0.0.1;Username=postgres;Password=dkcn09242627;Database=Projeto_Interdisciplinar";

                NpgsqlConnection conexao = new NpgsqlConnection(connString);

                //adaptador para os dados da tabela
                data_adapter = new NpgsqlDataAdapter();

                //string com o comando Select
                string strSelect = "SELECT p.nome, d.nome FROM professor p, disciplina d WHERE d.professor=p.codigop";

                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);

                //comand builder com insert, update e delete que são necessários para o data adapter

                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(data_adapter);

                //comando que cria e preenche uma tabela com os dados do Banco

                data_table = new DataTable();

                //acessa o banco e recupera os dados da tabela aluno e adiciona aos componentes do data_table

                data_adapter.Fill(data_table);

                //diz para o grid usar essa tabela como fonte de dados

                gvRel2.DataSource = data_table;


            }
            //tratamento de erros do Postgree
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanilhaAdm1 planilhaAdm1 = new PlanilhaAdm1();
            planilhaAdm1.Show();
        }

        private void Relatorio2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // libera todos os recursos não gerenciados mantidos por qualquer objeto que DataAdapter 
            // faça referência (NpgsqlConnection e NpgsqlCommand).
            if (data_adapter != null) data_adapter.Dispose();

            // libera os recursos não gerenciados do componente
            if (data_table != null) data_table.Dispose();

            
        }
    }
}
