namespace Interdisciplinar_Grafico_Final
{
    partial class Form1
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
            this.gvResponsavel = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvResponsavel)).BeginInit();
            this.SuspendLayout();
            // 
            // gvResponsavel
            // 
            this.gvResponsavel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvResponsavel.Location = new System.Drawing.Point(12, 80);
            this.gvResponsavel.Name = "gvResponsavel";
            this.gvResponsavel.Size = new System.Drawing.Size(810, 340);
            this.gvResponsavel.TabIndex = 0;
            this.gvResponsavel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvResponsavel_CellContentClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(377, 445);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(90, 30);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.Menu;
            this.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(12, 13);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(810, 61);
            this.Header.TabIndex = 2;
            this.Header.Text = "SISE";
            this.Header.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 501);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gvResponsavel);
            this.Name = "Form1";
            this.Text = "Área do Responsável";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvResponsavel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvResponsavel;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox Header;
    }
}