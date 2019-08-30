namespace ProjetoApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cbbVendedor = new System.Windows.Forms.ComboBox();
            this.lblValorDaCompra = new System.Windows.Forms.Label();
            this.txtValorDaCompra = new System.Windows.Forms.TextBox();
            this.gpbNumeroDeParcelas = new System.Windows.Forms.GroupBox();
            this.rdb3x = new System.Windows.Forms.RadioButton();
            this.rdb2x = new System.Windows.Forms.RadioButton();
            this.rdb1x = new System.Windows.Forms.RadioButton();
            this.lblValorDaParcela = new System.Windows.Forms.Label();
            this.txtValorDaParcela = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.gpbNumeroDeParcelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(13, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "&Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(63, 15);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(168, 20);
            this.txtCliente.TabIndex = 1;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(13, 55);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(65, 13);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "&Vendedor:";
            this.lblVendedor.Click += new System.EventHandler(this.lblVendedor_Click);
            // 
            // cbbVendedor
            // 
            this.cbbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbVendedor.FormattingEnabled = true;
            this.cbbVendedor.Location = new System.Drawing.Point(78, 52);
            this.cbbVendedor.Name = "cbbVendedor";
            this.cbbVendedor.Size = new System.Drawing.Size(153, 21);
            this.cbbVendedor.TabIndex = 3;
            // 
            // lblValorDaCompra
            // 
            this.lblValorDaCompra.AutoSize = true;
            this.lblValorDaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaCompra.ForeColor = System.Drawing.Color.White;
            this.lblValorDaCompra.Location = new System.Drawing.Point(13, 95);
            this.lblValorDaCompra.Name = "lblValorDaCompra";
            this.lblValorDaCompra.Size = new System.Drawing.Size(104, 13);
            this.lblValorDaCompra.TabIndex = 4;
            this.lblValorDaCompra.Text = "Valor da Compra:";
            this.lblValorDaCompra.Click += new System.EventHandler(this.lblValorDaCompra_Click);
            // 
            // txtValorDaCompra
            // 
            this.txtValorDaCompra.Location = new System.Drawing.Point(115, 92);
            this.txtValorDaCompra.Name = "txtValorDaCompra";
            this.txtValorDaCompra.Size = new System.Drawing.Size(116, 20);
            this.txtValorDaCompra.TabIndex = 5;
            // 
            // gpbNumeroDeParcelas
            // 
            this.gpbNumeroDeParcelas.Controls.Add(this.rdb3x);
            this.gpbNumeroDeParcelas.Controls.Add(this.rdb2x);
            this.gpbNumeroDeParcelas.Controls.Add(this.rdb1x);
            this.gpbNumeroDeParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbNumeroDeParcelas.ForeColor = System.Drawing.Color.White;
            this.gpbNumeroDeParcelas.Location = new System.Drawing.Point(16, 136);
            this.gpbNumeroDeParcelas.Name = "gpbNumeroDeParcelas";
            this.gpbNumeroDeParcelas.Size = new System.Drawing.Size(215, 62);
            this.gpbNumeroDeParcelas.TabIndex = 6;
            this.gpbNumeroDeParcelas.TabStop = false;
            this.gpbNumeroDeParcelas.Text = "Nº de &Parcelas";
            this.gpbNumeroDeParcelas.Enter += new System.EventHandler(this.gpbNumeroDeParcelas_Enter);
            // 
            // rdb3x
            // 
            this.rdb3x.AutoSize = true;
            this.rdb3x.Location = new System.Drawing.Point(157, 30);
            this.rdb3x.Name = "rdb3x";
            this.rdb3x.Size = new System.Drawing.Size(38, 17);
            this.rdb3x.TabIndex = 2;
            this.rdb3x.TabStop = true;
            this.rdb3x.Text = "3x";
            this.rdb3x.UseVisualStyleBackColor = true;
            // 
            // rdb2x
            // 
            this.rdb2x.AutoSize = true;
            this.rdb2x.Location = new System.Drawing.Point(89, 30);
            this.rdb2x.Name = "rdb2x";
            this.rdb2x.Size = new System.Drawing.Size(38, 17);
            this.rdb2x.TabIndex = 1;
            this.rdb2x.TabStop = true;
            this.rdb2x.Text = "2x";
            this.rdb2x.UseVisualStyleBackColor = true;
            // 
            // rdb1x
            // 
            this.rdb1x.AutoSize = true;
            this.rdb1x.Location = new System.Drawing.Point(23, 30);
            this.rdb1x.Name = "rdb1x";
            this.rdb1x.Size = new System.Drawing.Size(38, 17);
            this.rdb1x.TabIndex = 0;
            this.rdb1x.TabStop = true;
            this.rdb1x.Text = "1x";
            this.rdb1x.UseVisualStyleBackColor = true;
            // 
            // lblValorDaParcela
            // 
            this.lblValorDaParcela.AutoSize = true;
            this.lblValorDaParcela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDaParcela.ForeColor = System.Drawing.Color.White;
            this.lblValorDaParcela.Location = new System.Drawing.Point(13, 214);
            this.lblValorDaParcela.Name = "lblValorDaParcela";
            this.lblValorDaParcela.Size = new System.Drawing.Size(105, 13);
            this.lblValorDaParcela.TabIndex = 7;
            this.lblValorDaParcela.Text = "Valor da Parcela:";
            // 
            // txtValorDaParcela
            // 
            this.txtValorDaParcela.Enabled = false;
            this.txtValorDaParcela.Location = new System.Drawing.Point(115, 211);
            this.txtValorDaParcela.Name = "txtValorDaParcela";
            this.txtValorDaParcela.Size = new System.Drawing.Size(116, 20);
            this.txtValorDaParcela.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(130, 242);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 39);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnHistorico
            // 
            this.btnHistorico.BackColor = System.Drawing.Color.White;
            this.btnHistorico.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHistorico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorico.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHistorico.Location = new System.Drawing.Point(12, 242);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(106, 39);
            this.btnHistorico.TabIndex = 10;
            this.btnHistorico.Text = "Histórico de Vendas";
            this.btnHistorico.UseVisualStyleBackColor = false;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(248, 293);
            this.Controls.Add(this.btnHistorico);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorDaParcela);
            this.Controls.Add(this.lblValorDaParcela);
            this.Controls.Add(this.gpbNumeroDeParcelas);
            this.Controls.Add(this.txtValorDaCompra);
            this.Controls.Add(this.lblValorDaCompra);
            this.Controls.Add(this.cbbVendedor);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parcelamento";
            this.gpbNumeroDeParcelas.ResumeLayout(false);
            this.gpbNumeroDeParcelas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cbbVendedor;
        private System.Windows.Forms.Label lblValorDaCompra;
        private System.Windows.Forms.TextBox txtValorDaCompra;
        private System.Windows.Forms.GroupBox gpbNumeroDeParcelas;
        private System.Windows.Forms.RadioButton rdb3x;
        private System.Windows.Forms.RadioButton rdb2x;
        private System.Windows.Forms.RadioButton rdb1x;
        private System.Windows.Forms.Label lblValorDaParcela;
        private System.Windows.Forms.TextBox txtValorDaParcela;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnHistorico;
    }
}

