namespace Interdisciplinar_Grafico_Final
{
    partial class LoginAluno
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
            this.Header = new System.Windows.Forms.TextBox();
            this.SubHeader = new System.Windows.Forms.TextBox();
            this.Instrucao1 = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.instrucao2 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Menu;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(360, 61);
            this.Header.TabIndex = 0;
            this.Header.Text = "SISE";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SubHeader
            // 
            this.SubHeader.BackColor = System.Drawing.SystemColors.Menu;
            this.SubHeader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubHeader.Location = new System.Drawing.Point(12, 80);
            this.SubHeader.Name = "SubHeader";
            this.SubHeader.Size = new System.Drawing.Size(360, 23);
            this.SubHeader.TabIndex = 1;
            this.SubHeader.Text = "Área do Aluno";
            this.SubHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Instrucao1
            // 
            this.Instrucao1.BackColor = System.Drawing.SystemColors.Menu;
            this.Instrucao1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Instrucao1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instrucao1.Location = new System.Drawing.Point(12, 145);
            this.Instrucao1.Name = "Instrucao1";
            this.Instrucao1.Size = new System.Drawing.Size(360, 16);
            this.Instrucao1.TabIndex = 2;
            this.Instrucao1.Text = "Nome de Usuário";
            this.Instrucao1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(110, 170);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(170, 20);
            this.txtUser.TabIndex = 3;
            // 
            // instrucao2
            // 
            this.instrucao2.BackColor = System.Drawing.SystemColors.Menu;
            this.instrucao2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instrucao2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucao2.Location = new System.Drawing.Point(12, 215);
            this.instrucao2.Name = "instrucao2";
            this.instrucao2.Size = new System.Drawing.Size(360, 16);
            this.instrucao2.TabIndex = 4;
            this.instrucao2.Text = "Senha:";
            this.instrucao2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(110, 240);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(170, 20);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(160, 270);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 35);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(15, 320);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // LoginAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.instrucao2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.Instrucao1);
            this.Controls.Add(this.SubHeader);
            this.Controls.Add(this.Header);
            this.Name = "LoginAluno";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.TextBox SubHeader;
        private System.Windows.Forms.TextBox Instrucao1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox instrucao2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnVoltar;
    }
}