namespace Interdisciplinar_Grafico_Final
{
    partial class PlanilhasProf
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnRemoverAl = new System.Windows.Forms.Button();
            this.btnSalvarAl = new System.Windows.Forms.Button();
            this.gvAluno = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPlHis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(808, 61);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "SISE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRemoverAl
            // 
            this.btnRemoverAl.Location = new System.Drawing.Point(743, 464);
            this.btnRemoverAl.Name = "btnRemoverAl";
            this.btnRemoverAl.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverAl.TabIndex = 1;
            this.btnRemoverAl.Text = "Remover";
            this.btnRemoverAl.UseVisualStyleBackColor = true;
            this.btnRemoverAl.Click += new System.EventHandler(this.btnRemoverAl_Click);
            // 
            // btnSalvarAl
            // 
            this.btnSalvarAl.Location = new System.Drawing.Point(743, 435);
            this.btnSalvarAl.Name = "btnSalvarAl";
            this.btnSalvarAl.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarAl.TabIndex = 2;
            this.btnSalvarAl.Text = "Salvar";
            this.btnSalvarAl.UseVisualStyleBackColor = true;
            this.btnSalvarAl.Click += new System.EventHandler(this.btnSalvarAl_Click);
            // 
            // gvAluno
            // 
            this.gvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAluno.Location = new System.Drawing.Point(12, 80);
            this.gvAluno.Name = "gvAluno";
            this.gvAluno.Size = new System.Drawing.Size(810, 340);
            this.gvAluno.TabIndex = 3;
            this.gvAluno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAluno_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 435);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPlHis
            // 
            this.btnPlHis.Location = new System.Drawing.Point(12, 464);
            this.btnPlHis.Name = "btnPlHis";
            this.btnPlHis.Size = new System.Drawing.Size(75, 23);
            this.btnPlHis.TabIndex = 5;
            this.btnPlHis.Text = "Histórico";
            this.btnPlHis.UseVisualStyleBackColor = true;
            this.btnPlHis.Click += new System.EventHandler(this.btnPlHis_Click);
            // 
            // PlanilhasProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.btnPlHis);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gvAluno);
            this.Controls.Add(this.btnSalvarAl);
            this.Controls.Add(this.btnRemoverAl);
            this.Controls.Add(this.textBox1);
            this.Name = "PlanilhasProf";
            this.Text = "Área do Professor (Planilha Aluno)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlanilhasProf_FormClosing);
            this.Load += new System.EventHandler(this.PlanilhasProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRemoverAl;
        private System.Windows.Forms.Button btnSalvarAl;
        private System.Windows.Forms.DataGridView gvAluno;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPlHis;
    }
}