namespace MatriculaAlunoV2
{
    partial class frmCategoriaPorIdadeV2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.bntIdentificarCategoria = new System.Windows.Forms.Button();
            this.lbHoje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategoria.ForeColor = System.Drawing.Color.Blue;
            this.lbCategoria.Location = new System.Drawing.Point(169, 96);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(152, 36);
            this.lbCategoria.TabIndex = 3;
            this.lbCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 20);
            this.txtNome.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(25, 70);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtpDataNascimento.TabIndex = 5;
            // 
            // bntIdentificarCategoria
            // 
            this.bntIdentificarCategoria.Location = new System.Drawing.Point(25, 96);
            this.bntIdentificarCategoria.Name = "bntIdentificarCategoria";
            this.bntIdentificarCategoria.Size = new System.Drawing.Size(138, 36);
            this.bntIdentificarCategoria.TabIndex = 8;
            this.bntIdentificarCategoria.Text = "Identificar Categoria";
            this.bntIdentificarCategoria.UseVisualStyleBackColor = true;
            this.bntIdentificarCategoria.Click += new System.EventHandler(this.BntIdentificarCategoria_Click);
            // 
            // lbHoje
            // 
            this.lbHoje.AutoSize = true;
            this.lbHoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoje.Location = new System.Drawing.Point(172, 70);
            this.lbHoje.Name = "lbHoje";
            this.lbHoje.Size = new System.Drawing.Size(56, 20);
            this.lbHoje.TabIndex = 9;
            this.lbHoje.Text = "Atual.";
            // 
            // frmCategoriaPorIdadeV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 148);
            this.Controls.Add(this.lbHoje);
            this.Controls.Add(this.bntIdentificarCategoria);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmCategoriaPorIdadeV2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Button bntIdentificarCategoria;
        private System.Windows.Forms.Label lbHoje;
    }
}

