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
    public partial class Inicio : Form
    {
        int selecao = 0;
        public Inicio()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            selecao= 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (selecao == 1)
            {
                this.Hide();
                LoginProfessor loginProfessor = new LoginProfessor();
                loginProfessor.Show();

            }
            else if (selecao == 2)
            {
                this.Hide();
                LoginAluno loginAluno = new LoginAluno();
                loginAluno.Show();
            }
            else if (selecao == 3)
            {
                this.Hide();
                LoginResponsavel loginResponsavel = new LoginResponsavel();
                loginResponsavel.Show();
            }
            else if (selecao == 4)
            {
                this.Hide();
                LoginAdm loginAdm = new LoginAdm();
                loginAdm.Show();
            }
            
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            selecao = 2;
        }

        private void Responsavel_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 3;
        }

        private void Administrativo_CheckedChanged(object sender, EventArgs e)
        {
            selecao = 4;
        }
    }
}
