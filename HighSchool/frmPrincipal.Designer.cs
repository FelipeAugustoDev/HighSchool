namespace HighSchool
{
    partial class frmPrincipal
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
            this.lboAlunos = new System.Windows.Forms.ListBox();
            this.lboMedias = new System.Windows.Forms.ListBox();
            this.btnDados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboAlunos
            // 
            this.lboAlunos.FormattingEnabled = true;
            this.lboAlunos.Location = new System.Drawing.Point(12, 12);
            this.lboAlunos.Name = "lboAlunos";
            this.lboAlunos.Size = new System.Drawing.Size(120, 225);
            this.lboAlunos.TabIndex = 0;
            // 
            // lboMedias
            // 
            this.lboMedias.FormattingEnabled = true;
            this.lboMedias.Location = new System.Drawing.Point(172, 12);
            this.lboMedias.Name = "lboMedias";
            this.lboMedias.Size = new System.Drawing.Size(120, 225);
            this.lboMedias.TabIndex = 1;
            // 
            // btnDados
            // 
            this.btnDados.Location = new System.Drawing.Point(108, 243);
            this.btnDados.Name = "btnDados";
            this.btnDados.Size = new System.Drawing.Size(84, 56);
            this.btnDados.TabIndex = 2;
            this.btnDados.Text = "Dados";
            this.btnDados.UseVisualStyleBackColor = true;
            this.btnDados.Click += new System.EventHandler(this.btnDados_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 317);
            this.Controls.Add(this.btnDados);
            this.Controls.Add(this.lboMedias);
            this.Controls.Add(this.lboAlunos);
            this.Name = "frmPrincipal";
            this.Text = "High School";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboAlunos;
        private System.Windows.Forms.ListBox lboMedias;
        private System.Windows.Forms.Button btnDados;
    }
}

