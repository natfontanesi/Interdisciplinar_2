namespace Interdisciplinar_Grafico_Final
{
    partial class Inicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BoasVindas = new System.Windows.Forms.TextBox();
            this.Professor = new System.Windows.Forms.RadioButton();
            this.Aluno = new System.Windows.Forms.RadioButton();
            this.Responsavel = new System.Windows.Forms.RadioButton();
            this.Administrativo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Instruçao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoasVindas
            // 
            this.BoasVindas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoasVindas.BackColor = System.Drawing.SystemColors.Menu;
            this.BoasVindas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoasVindas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.BoasVindas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoasVindas.Location = new System.Drawing.Point(-1, 27);
            this.BoasVindas.Multiline = true;
            this.BoasVindas.Name = "BoasVindas";
            this.BoasVindas.ReadOnly = true;
            this.BoasVindas.Size = new System.Drawing.Size(521, 30);
            this.BoasVindas.TabIndex = 0;
            this.BoasVindas.Text = "BEM-VINDO AO SISE!";
            this.BoasVindas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoasVindas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Professor
            // 
            this.Professor.AutoSize = true;
            this.Professor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Professor.Location = new System.Drawing.Point(203, 126);
            this.Professor.Name = "Professor";
            this.Professor.Size = new System.Drawing.Size(87, 21);
            this.Professor.TabIndex = 1;
            this.Professor.TabStop = true;
            this.Professor.Text = "Professor";
            this.Professor.UseVisualStyleBackColor = true;
            this.Professor.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Aluno
            // 
            this.Aluno.AutoSize = true;
            this.Aluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Aluno.Location = new System.Drawing.Point(203, 156);
            this.Aluno.Name = "Aluno";
            this.Aluno.Size = new System.Drawing.Size(62, 21);
            this.Aluno.TabIndex = 2;
            this.Aluno.TabStop = true;
            this.Aluno.Text = "Aluno";
            this.Aluno.UseVisualStyleBackColor = true;
            this.Aluno.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Responsavel
            // 
            this.Responsavel.AutoSize = true;
            this.Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Responsavel.Location = new System.Drawing.Point(203, 186);
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.Size = new System.Drawing.Size(108, 21);
            this.Responsavel.TabIndex = 3;
            this.Responsavel.TabStop = true;
            this.Responsavel.Text = "Responsável";
            this.Responsavel.UseVisualStyleBackColor = true;
            this.Responsavel.CheckedChanged += new System.EventHandler(this.Responsavel_CheckedChanged);
            // 
            // Administrativo
            // 
            this.Administrativo.AutoSize = true;
            this.Administrativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrativo.Location = new System.Drawing.Point(203, 216);
            this.Administrativo.Name = "Administrativo";
            this.Administrativo.Size = new System.Drawing.Size(114, 21);
            this.Administrativo.TabIndex = 4;
            this.Administrativo.TabStop = true;
            this.Administrativo.Text = "Administrativo";
            this.Administrativo.UseVisualStyleBackColor = true;
            this.Administrativo.CheckedChanged += new System.EventHandler(this.Administrativo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Próximo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instruçao
            // 
            this.Instruçao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Instruçao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instruçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruçao.Location = new System.Drawing.Point(12, 69);
            this.Instruçao.Name = "Instruçao";
            this.Instruçao.Size = new System.Drawing.Size(497, 23);
            this.Instruçao.TabIndex = 6;
            this.Instruçao.Text = "Para começar selecione qual o seu tipo de cadastro";
            this.Instruçao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 354);
            this.Controls.Add(this.Instruçao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Administrativo);
            this.Controls.Add(this.Responsavel);
            this.Controls.Add(this.Aluno);
            this.Controls.Add(this.Professor);
            this.Controls.Add(this.BoasVindas);
            this.Name = "Inicio";
            this.Text = "SISE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoasVindas;
        private System.Windows.Forms.RadioButton Professor;
        private System.Windows.Forms.RadioButton Aluno;
        private System.Windows.Forms.RadioButton Responsavel;
        private System.Windows.Forms.RadioButton Administrativo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Instruçao;
    }
}

