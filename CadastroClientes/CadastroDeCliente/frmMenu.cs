using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeCliente
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmClientes fCliente = new frmClientes();
            fCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario fFuncionario = new frmFuncionario();
            fFuncionario.ShowDialog();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            frmProdutos fProduto = new frmProdutos();
            fProduto.ShowDialog();
        }
    }
}
