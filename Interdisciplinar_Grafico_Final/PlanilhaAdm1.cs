using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interdisciplinar_Grafico_Final
{
    public partial class PlanilhaAdm1 : Form
    {
        int selecao = 0;
        public PlanilhaAdm1()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginAdm loginAdm = new LoginAdm();
            loginAdm.Show();
        }

        private void aluno_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 1;
        }

        private void professor_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 2;
        }

        private void disciplina_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 3;
        }

        private void curso_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 4;
        }

        private void turma_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 5;
        }

        private void historico_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 6;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (selecao == 1)
            {
                this.Hide();
                PlanilhaAdm2 planilhaAdm2 = new PlanilhaAdm2();
                planilhaAdm2.Show();

            }
            else if (selecao == 2)
            {
                this.Hide();
                PlanilhaAdm3 planilhaAdm3 = new PlanilhaAdm3();
                planilhaAdm3.Show();
            }
            else if (selecao == 3)
            {
                this.Hide();
                PlanilhaAdm4 planilhaAdm4 = new PlanilhaAdm4();
                planilhaAdm4.Show();
            }
            else if (selecao == 4)
            {
                this.Hide();
                PlanilhaAdm5 planilhaAdm5 = new PlanilhaAdm5();
                planilhaAdm5.Show();
            }
            else if (selecao == 5)
            {
                this.Hide();
                PlanilhaAdm6 planilhaAdm6 = new PlanilhaAdm6();
                planilhaAdm6.Show();
            }
            else if (selecao == 6)
            {
                this.Hide();
                PlanilhaAdm7 planilhaAdm7 = new PlanilhaAdm7();
                planilhaAdm7.Show();
            }
            else if (selecao == 7)
            {
                this.Hide();
                Relatorio1 relatorio1 = new Relatorio1();
                relatorio1.Show();
            }
            else if (selecao == 8)
            {
                this.Hide();
                Relatorio2 relatorio2 = new Relatorio2();
                relatorio2.Show();
            }
            else if (selecao == 9)
            {
                this.Hide();
                Relatorio3 relatorio3 = new Relatorio3();
                relatorio3.Show();
            }
        }

        private void rel_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 7;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 8;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 9;
        }

        private void PlanilhaAdm1_Load(object sender, EventArgs e)
        {

        }

        private void PlanilhaAdm1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();

        }
    }
}
