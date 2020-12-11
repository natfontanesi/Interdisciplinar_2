namespace Interdisciplinar_Grafico_Final
{
    partial class Relatorio1
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
            this.gvRelatorio1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvRelatorio1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvRelatorio1
            // 
            this.gvRelatorio1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRelatorio1.Location = new System.Drawing.Point(12, 80);
            this.gvRelatorio1.Name = "gvRelatorio1";
            this.gvRelatorio1.Size = new System.Drawing.Size(810, 340);
            this.gvRelatorio1.TabIndex = 0;
            this.gvRelatorio1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRelatorio1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(810, 61);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "SISE";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // Relatorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gvRelatorio1);
            this.Name = "Relatorio1";
            this.Text = "Relatório Aluno/Histórico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Relatorio1_FormClosing);
            this.Load += new System.EventHandler(this.Relatorio1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvRelatorio1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvRelatorio1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVoltar;
    }
}