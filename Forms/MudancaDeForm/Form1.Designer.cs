namespace MudancaDeForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAbrirForm2 = new System.Windows.Forms.Button();
            this.btnAcrescimo = new System.Windows.Forms.Button();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnAbrirForm2
            // 
            this.btnAbrirForm2.Image = ((System.Drawing.Image)(resources.GetObject("btnAbrirForm2.Image")));
            this.btnAbrirForm2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirForm2.Location = new System.Drawing.Point(12, 12);
            this.btnAbrirForm2.Name = "btnAbrirForm2";
            this.btnAbrirForm2.Size = new System.Drawing.Size(128, 46);
            this.btnAbrirForm2.TabIndex = 0;
            this.btnAbrirForm2.Text = "Abrir Form 2";
            this.btnAbrirForm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirForm2.UseVisualStyleBackColor = true;
            this.btnAbrirForm2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAcrescimo
            // 
            this.btnAcrescimo.Image = ((System.Drawing.Image)(resources.GetObject("btnAcrescimo.Image")));
            this.btnAcrescimo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcrescimo.Location = new System.Drawing.Point(12, 64);
            this.btnAcrescimo.Name = "btnAcrescimo";
            this.btnAcrescimo.Size = new System.Drawing.Size(128, 46);
            this.btnAcrescimo.TabIndex = 1;
            this.btnAcrescimo.Text = "Acréscimo";
            this.btnAcrescimo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcrescimo.UseVisualStyleBackColor = true;
            this.btnAcrescimo.Click += new System.EventHandler(this.btnAcrescimo_Click);
            // 
            // btnDesconto
            // 
            this.btnDesconto.Image = ((System.Drawing.Image)(resources.GetObject("btnDesconto.Image")));
            this.btnDesconto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesconto.Location = new System.Drawing.Point(12, 116);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(128, 46);
            this.btnDesconto.TabIndex = 2;
            this.btnDesconto.Text = "Desconto";
            this.btnDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalculadora.Location = new System.Drawing.Point(12, 168);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(128, 46);
            this.btnCalculadora.TabIndex = 3;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(162, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 45);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 223);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.btnAcrescimo);
            this.Controls.Add(this.btnAbrirForm2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirForm2;
        private System.Windows.Forms.Button btnAcrescimo;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

