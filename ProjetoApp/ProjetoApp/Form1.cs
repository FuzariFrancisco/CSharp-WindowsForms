using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjetoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbVendedor.Items.Add("Vendedor 1");
            cbbVendedor.Items.Add("Vendedor 2");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Parcelas;
            
            if (txtCliente.Text == String.Empty)
            {
                MessageBox.Show("Campo cliente não pode estar vazio.", "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtCliente.Focus();
            }
            else if (cbbVendedor.Text == String.Empty)
            {
                MessageBox.Show("Campo Vendedor não pode estar vazio.", "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                cbbVendedor.Focus();
            }
            else if (txtValorDaCompra.Text == String.Empty)
            {
                MessageBox.Show("Campo Valor da compra não pode estar vazio.", "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtValorDaCompra.Focus();
            }

            if (rdb1x.Checked == true)
            {
                txtValorDaParcela.Text = "R$ " + (Convert.ToDouble(txtValorDaCompra.Text) / 1).ToString();
                Parcelas = 1;
            }
            else if (rdb2x.Checked == true)
            {
                txtValorDaParcela.Text = "R$ " + (Convert.ToDouble(txtValorDaCompra.Text) / 2).ToString();
                Parcelas = 2;
            }
            else if (rdb3x.Checked == true)
            {
                txtValorDaParcela.Text = "R$ " + (Convert.ToDouble(txtValorDaCompra.Text) / 3).ToString();
                Parcelas = 3;
            }
            else
            {
                txtValorDaParcela.Text = "R$ " + txtValorDaCompra.Text ;
                Parcelas = 1;
            }
            GravarCompra(Parcelas);
        }
        private void GravarCompra(int Parcelas)
        {
            //CRIE A PASTA Teste NO C:
            StreamWriter arquivo;
            string caminho = "C:\\Teste\\compras.txt";
            arquivo = File.AppendText(caminho);

            arquivo.WriteLine("---------------------------------------------------");
            arquivo.WriteLine("Vendedor: " + cbbVendedor.Text);
            arquivo.WriteLine("Cliente: " + txtCliente.Text);
            arquivo.WriteLine("Valor da compra: " + "R$" + txtValorDaCompra.Text);
            arquivo.WriteLine(Parcelas + " Parcelas de: " + txtValorDaParcela.Text );
            arquivo.WriteLine("Data e hora da compra: " + DateTime.Now);
            arquivo.WriteLine("---------------------------------------------------");
            arquivo.WriteLine();

            arquivo.Close();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            string caminho = "C:\\Teste\\compras.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void lblVendedor_Click(object sender, EventArgs e)
        {

        }

        private void lblValorDaCompra_Click(object sender, EventArgs e)
        {

        }

        private void gpbNumeroDeParcelas_Enter(object sender, EventArgs e)
        {

        }
    }
}
