namespace CadastroDeAlunos2
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnExibeCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblExibeCategoria = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblDataDeHoje = new System.Windows.Forms.Label();
            this.dtpDataDeNascimento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "&Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(56, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(368, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnExibeCategoria
            // 
            this.btnExibeCategoria.Location = new System.Drawing.Point(21, 80);
            this.btnExibeCategoria.Name = "btnExibeCategoria";
            this.btnExibeCategoria.Size = new System.Drawing.Size(202, 23);
            this.btnExibeCategoria.TabIndex = 2;
            this.btnExibeCategoria.Text = "Identificar Categoria";
            this.btnExibeCategoria.UseVisualStyleBackColor = true;
            this.btnExibeCategoria.Click += new System.EventHandler(this.btnExibeCategoria_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(229, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblExibeCategoria
            // 
            this.lblExibeCategoria.BackColor = System.Drawing.Color.Yellow;
            this.lblExibeCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExibeCategoria.Location = new System.Drawing.Point(290, 80);
            this.lblExibeCategoria.Name = "lblExibeCategoria";
            this.lblExibeCategoria.Size = new System.Drawing.Size(131, 23);
            this.lblExibeCategoria.TabIndex = 4;
            this.lblExibeCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(18, 53);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // lblDataDeHoje
            // 
            this.lblDataDeHoje.AutoSize = true;
            this.lblDataDeHoje.Location = new System.Drawing.Point(341, 53);
            this.lblDataDeHoje.Name = "lblDataDeHoje";
            this.lblDataDeHoje.Size = new System.Drawing.Size(85, 13);
            this.lblDataDeHoje.TabIndex = 6;
            this.lblDataDeHoje.Text = "DATA DE HOJE";
            // 
            // dtpDataDeNascimento
            // 
            this.dtpDataDeNascimento.Location = new System.Drawing.Point(123, 49);
            this.dtpDataDeNascimento.Name = "dtpDataDeNascimento";
            this.dtpDataDeNascimento.Size = new System.Drawing.Size(212, 20);
            this.dtpDataDeNascimento.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 117);
            this.Controls.Add(this.dtpDataDeNascimento);
            this.Controls.Add(this.lblDataDeHoje);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblExibeCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnExibeCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnExibeCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblExibeCategoria;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblDataDeHoje;
        private System.Windows.Forms.DateTimePicker dtpDataDeNascimento;
    }
}

