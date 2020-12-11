namespace Interdisciplinar_Grafico_Final
{
    partial class PlanilhaAdm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aluno = new System.Windows.Forms.RadioButton();
            this.professor = new System.Windows.Forms.RadioButton();
            this.disciplina = new System.Windows.Forms.RadioButton();
            this.curso = new System.Windows.Forms.RadioButton();
            this.turma = new System.Windows.Forms.RadioButton();
            this.historico = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Header = new System.Windows.Forms.TextBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rel = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // aluno
            // 
            this.aluno.AutoSize = true;
            this.aluno.Location = new System.Drawing.Point(118, 160);
            this.aluno.Name = "aluno";
            this.aluno.Size = new System.Drawing.Size(92, 17);
            this.aluno.TabIndex = 0;
            this.aluno.TabStop = true;
            this.aluno.Text = "Planilha Aluno";
            this.aluno.UseVisualStyleBackColor = true;
            this.aluno.CheckedChanged += new System.EventHandler(this.aluno_CheckedChanged);
            // 
            // professor
            // 
            this.professor.AutoSize = true;
            this.professor.Location = new System.Drawing.Point(118, 200);
            this.professor.Name = "professor";
            this.professor.Size = new System.Drawing.Size(109, 17);
            this.professor.TabIndex = 1;
            this.professor.TabStop = true;
            this.professor.Text = "Planilha Professor";
            this.professor.UseVisualStyleBackColor = true;
            this.professor.CheckedChanged += new System.EventHandler(this.professor_CheckedChanged);
            // 
            // disciplina
            // 
            this.disciplina.AutoSize = true;
            this.disciplina.Location = new System.Drawing.Point(118, 240);
            this.disciplina.Name = "disciplina";
            this.disciplina.Size = new System.Drawing.Size(110, 17);
            this.disciplina.TabIndex = 2;
            this.disciplina.TabStop = true;
            this.disciplina.Text = "Planilha Disciplina";
            this.disciplina.UseVisualStyleBackColor = true;
            this.disciplina.CheckedChanged += new System.EventHandler(this.disciplina_CheckedChanged);
            // 
            // curso
            // 
            this.curso.AutoSize = true;
            this.curso.Location = new System.Drawing.Point(359, 160);
            this.curso.Name = "curso";
            this.curso.Size = new System.Drawing.Size(92, 17);
            this.curso.TabIndex = 3;
            this.curso.TabStop = true;
            this.curso.Text = "Planilha Curso";
            this.curso.UseVisualStyleBackColor = true;
            this.curso.CheckedChanged += new System.EventHandler(this.curso_CheckedChanged);
            // 
            // turma
            // 
            this.turma.AutoSize = true;
            this.turma.Location = new System.Drawing.Point(359, 200);
            this.turma.Name = "turma";
            this.turma.Size = new System.Drawing.Size(95, 17);
            this.turma.TabIndex = 4;
            this.turma.TabStop = true;
            this.turma.Text = "Planilha Turma";
            this.turma.UseVisualStyleBackColor = true;
            this.turma.CheckedChanged += new System.EventHandler(this.turma_CheckedChanged);
            // 
            // historico
            // 
            this.historico.AutoSize = true;
            this.historico.Location = new System.Drawing.Point(359, 240);
            this.historico.Name = "historico";
            this.historico.Size = new System.Drawing.Size(106, 17);
            this.historico.TabIndex = 5;
            this.historico.TabStop = true;
            this.historico.Text = "Planilha Histórico";
            this.historico.UseVisualStyleBackColor = true;
            this.historico.CheckedChanged += new System.EventHandler(this.historico_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(810, 16);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Selecione abaixo a planilha que deseja consultar ou alterar:";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Menu;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(810, 61);
            this.Header.TabIndex = 7;
            this.Header.Text = "SISE";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(359, 299);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(110, 42);
            this.btnProximo.TabIndex = 8;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 344);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 37);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rel
            // 
            this.rel.AutoSize = true;
            this.rel.Location = new System.Drawing.Point(600, 160);
            this.rel.Name = "rel";
            this.rel.Size = new System.Drawing.Size(143, 17);
            this.rel.TabIndex = 10;
            this.rel.TabStop = true;
            this.rel.Text = "Relatório Aluno/Histórico";
            this.rel.UseVisualStyleBackColor = true;
            this.rel.CheckedChanged += new System.EventHandler(this.rel_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(600, 200);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(164, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Relatório Professor/Disciplina";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(600, 240);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(105, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Relatório Turmas";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // PlanilhaAdm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 401);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.rel);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.historico);
            this.Controls.Add(this.turma);
            this.Controls.Add(this.curso);
            this.Controls.Add(this.disciplina);
            this.Controls.Add(this.professor);
            this.Controls.Add(this.aluno);
            this.Name = "PlanilhaAdm1";
            this.Text = "Área do Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanilhaAdm1_FormClosing);
            this.Load += new System.EventHandler(this.PlanilhaAdm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton aluno;
        private System.Windows.Forms.RadioButton professor;
        private System.Windows.Forms.RadioButton disciplina;
        private System.Windows.Forms.RadioButton curso;
        private System.Windows.Forms.RadioButton turma;
        private System.Windows.Forms.RadioButton historico;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton rel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}