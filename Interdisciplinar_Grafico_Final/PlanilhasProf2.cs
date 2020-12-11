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
    public partial class PlanilhasProf2 : Form
    {
        private NpgsqlDataAdapter data_adapter;
        private DataTable data_table;
        public PlanilhasProf2()
        {
            InitializeComponent();
        }

        private void PlanilhasProf2_Load(object sender, EventArgs e)
        {
            try
            {
                //string de conexão com o banco de dados
                string connString = @"Host=127.0.0.1;Username=postgres;Password=dkcn09242627;Database=Projeto_Interdisciplinar";

                NpgsqlConnection conexao = new NpgsqlConnection(connString);

                //adaptador para os dados da tabela
                data_adapter = new NpgsqlDataAdapter();

                //string com o comando Select
                string strSelect = "SELECT * FROM historico";

                data_adapter.SelectCommand = new NpgsqlCommand(strSelect, conexao);

                //comand builder com insert, update e delete que são necessários para o data adapter

                NpgsqlCommandBuilder cmdBuilder = new NpgsqlCommandBuilder(data_adapter);

                //comando que cria e preenche uma tabela com os dados do Banco

                data_table = new DataTable();

                //acessa o banco e recupera os dados da tabela aluno e adiciona aos componentes do data_table

                data_adapter.Fill(data_table);

                //diz para o grid usar essa tabela como fonte de dados

                dataGridView1.DataSource = data_table;

                //oculta a coluna de chave primaria
                dataGridView1.Columns["codigoh"].Visible = false;

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //atualiza os dados inseridos no gride para o bd.
            data_adapter.Update(data_table);

            //avisa ao usuário que os dados foram salvos
            MessageBox.Show("Dados Salvos com Sucesso!");
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //remove todas as linhas selecionadas  do gvAluno
            // o gvAluno ira remover (automaticamente) essas linhas da data_table

            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);
                }

            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginProfessor loginProfessor = new LoginProfessor();
            loginProfessor.Show();
        }

        private void btnPlAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlanilhasProf planilhasProf = new PlanilhasProf();
            planilhasProf.Show();
        }

        private void PlanilhasProf2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // libera todos os recursos não gerenciados mantidos por qualquer objeto que DataAdapter 
            // faça referência (NpgsqlConnection e NpgsqlCommand).
            if (data_adapter != null) data_adapter.Dispose();

            // libera os recursos não gerenciados do componente
            if (data_table != null) data_table.Dispose();

            
        }
    }
}
