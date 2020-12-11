namespace Interdisciplinar_Grafico_Final
{
    partial class PlanilhaAdm2
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
            this.gvAdmAluno = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAdmAluno
            // 
            this.gvAdmAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAdmAluno.Location = new System.Drawing.Point(12, 80);
            this.gvAdmAluno.Name = "gvAdmAluno";
            this.gvAdmAluno.Size = new System.Drawing.Size(810, 340);
            this.gvAdmAluno.TabIndex = 0;
            this.gvAdmAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAdmAluno_CellContentClick);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Menu;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 12);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(810, 61);
            this.Header.TabIndex = 1;
            this.Header.Text = "SISE";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 455);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(743, 435);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(743, 464);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // PlanilhaAdm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.gvAdmAluno);
            this.Name = "PlanilhaAdm2";
            this.Text = "Planilha Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanilhaAdm2_FormClosing);
            this.Load += new System.EventHandler(this.PlanilhaAdm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAdmAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvAdmAluno;
        private System.Windows.Forms.TextBox Header;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnRemover;
    }
}