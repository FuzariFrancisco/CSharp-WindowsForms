using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeCliente
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string Produto = txtProduto.Text, Quantidade = txtQuantidade.Text, Valor = txtValor.Text;
            GravaProduto(Produto, Quantidade, Valor);
            LimpaTela();
        }

        private void GravaProduto(string produto, string quantidade, string valor)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\produsttos.txt";
            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Cadastro de Produtos");
            arquivo.WriteLine("Pruduto: " + produto);
            arquivo.WriteLine("Quantidade: "+ quantidade);
            arquivo.WriteLine("Valor: "+ valor);
            arquivo.WriteLine("=====================================");
            arquivo.WriteLine("");
            arquivo.WriteLine("");
            arquivo.Close();
        }

        private void LimpaTela()
        {
            txtProduto.Text = "";
            txtQuantidade.Text = "";
            txtValor.Text = "";
        }
    }
}
