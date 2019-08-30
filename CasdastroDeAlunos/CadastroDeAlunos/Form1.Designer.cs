namespace CadastroDeAlunos
{
    partial class Form1
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
            this.lblExibeCategoria = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblAnoNascimento = new System.Windows.Forms.Label();
            this.txtAnoNascimento = new System.Windows.Forms.TextBox();
            this.lblAnoAniversario = new System.Windows.Forms.Label();
            this.txtAnoAniversario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblExibeCategoria
            // 
            this.lblExibeCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblExibeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExibeCategoria.Location = new System.Drawing.Point(182, 74);
            this.lblExibeCategoria.Name = "lblExibeCategoria";
            this.lblExibeCategoria.Size = new System.Drawing.Size(129, 20);
            this.lblExibeCategoria.TabIndex = 7;
            this.lblExibeCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExibeCategoria.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(127, 77);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btnCategoria
            // 
            this.btnCategoria.Location = new System.Drawing.Point(12, 72);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(109, 23);
            this.btnCategoria.TabIndex = 9;
            this.btnCategoria.Text = "Identificar Categoria";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 14);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(44, 11);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(271, 20);
            this.txtNome.TabIndex = 11;
            // 
            // lblAnoNascimento
            // 
            this.lblAnoNascimento.AutoSize = true;
            this.lblAnoNascimento.Location = new System.Drawing.Point(9, 44);
            this.lblAnoNascimento.Name = "lblAnoNascimento";
            this.lblAnoNascimento.Size = new System.Drawing.Size(88, 13);
            this.lblAnoNascimento.TabIndex = 12;
            this.lblAnoNascimento.Text = "&Ano Nascimento:";
            // 
            // txtAnoNascimento
            // 
            this.txtAnoNascimento.Location = new System.Drawing.Point(97, 41);
            this.txtAnoNascimento.Name = "txtAnoNascimento";
            this.txtAnoNascimento.Size = new System.Drawing.Size(48, 20);
            this.txtAnoNascimento.TabIndex = 13;
            // 
            // lblAnoAniversario
            // 
            this.lblAnoAniversario.AutoSize = true;
            this.lblAnoAniversario.Location = new System.Drawing.Point(145, 44);
            this.lblAnoAniversario.Name = "lblAnoAniversario";
            this.lblAnoAniversario.Size = new System.Drawing.Size(116, 13);
            this.lblAnoAniversario.TabIndex = 14;
            this.lblAnoAniversario.Text = "An&o Último Aniversário:";
            // 
            // txtAnoAniversario
            // 
            this.txtAnoAniversario.Location = new System.Drawing.Point(267, 41);
            this.txtAnoAniversario.Name = "txtAnoAniversario";
            this.txtAnoAniversario.Size = new System.Drawing.Size(48, 20);
            this.txtAnoAniversario.TabIndex = 15;
            this.txtAnoAniversario.TextChanged += new System.EventHandler(this.txtAnoAniversario_TextChanged);
            this.txtAnoAniversario.Enter += new System.EventHandler(this.textBox2_Enter);
            this.txtAnoAniversario.Validating += new System.ComponentModel.CancelEventHandler(this.txtAnoAniversario_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 104);
            this.Controls.Add(this.txtAnoAniversario);
            this.Controls.Add(this.lblAnoAniversario);
            this.Controls.Add(this.txtAnoNascimento);
            this.Controls.Add(this.lblAnoNascimento);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblExibeCategoria);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblExibeCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblAnoNascimento;
        private System.Windows.Forms.TextBox txtAnoNascimento;
        private System.Windows.Forms.Label lblAnoAniversario;
        private System.Windows.Forms.TextBox txtAnoAniversario;
    }
}

