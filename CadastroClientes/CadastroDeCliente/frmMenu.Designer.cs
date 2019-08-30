namespace CadastroDeCliente
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnCadastroFuncionario = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroCliente.Image")));
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(12, 12);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(198, 72);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastro de Clientes";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroCliente.UseVisualStyleBackColor = true;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastroFuncionario
            // 
            this.btnCadastroFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroFuncionario.Image")));
            this.btnCadastroFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroFuncionario.Location = new System.Drawing.Point(12, 90);
            this.btnCadastroFuncionario.Name = "btnCadastroFuncionario";
            this.btnCadastroFuncionario.Size = new System.Drawing.Size(198, 72);
            this.btnCadastroFuncionario.TabIndex = 1;
            this.btnCadastroFuncionario.Text = "Cadastro de Funcionários";
            this.btnCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionario.Click += new System.EventHandler(this.btnCadastroFuncionario_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroProduto.Image")));
            this.btnCadastroProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroProduto.Location = new System.Drawing.Point(12, 168);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(198, 72);
            this.btnCadastroProduto.TabIndex = 2;
            this.btnCadastroProduto.Text = "Cadastro de Produtos";
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastroProduto.UseVisualStyleBackColor = true;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(12, 246);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(197, 40);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 297);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCadastroProduto);
            this.Controls.Add(this.btnCadastroFuncionario);
            this.Controls.Add(this.btnCadastroCliente);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnCadastroFuncionario;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnSair;
    }
}