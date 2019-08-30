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

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == String.Empty)
            {
                MessageBox.Show("Insira o Nome");
                txtNome.Focus();
            }

            else if (txtEmail.Text == String.Empty)
            {
                MessageBox.Show("Insira o e-mail");
                txtEmail.Focus();
            }

            else if (txtTelefone.Text == String.Empty)
            {
                MessageBox.Show("Insira o Telefone");
                txtTelefone.Focus();
            }

            else if (txtRg.Text == String.Empty)
            {
                MessageBox.Show("Insira o RG");
                txtRg.Focus();
            }
            else
            {
                GravarCadastro();
            }
        }

        private void GravarCadastro()
        {
            //CRIE A PASTA Cadastros NO C:

            StreamWriter arquivo;
            string caminho = "C:\\Cadastros\\compras.txt";
            arquivo = File.AppendText(caminho);

            arquivo.WriteLine("---------------------------------");
            arquivo.WriteLine("Nome: " + txtNome.Text);
            arquivo.WriteLine("E-mail: " + txtEmail.Text);
            arquivo.WriteLine("Telefone: " + txtTelefone.Text);
            arquivo.WriteLine("RG: " + txtRg.Text);
            arquivo.WriteLine("---------------------------------");
            arquivo.Close();
        }

        private void ExibirCadastro()
        {
            string caminho = "C:\\Cadastros\\compras.txt";
            System.Diagnostics.Process.Start("notepad", caminho);
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            ExibirCadastro();
        }
    }
}
