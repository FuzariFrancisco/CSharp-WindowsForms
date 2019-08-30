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
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string estadoCivil, escolaridade, nome, email, telefone, celular,
                cidade, estado;
            nome = txtNome.Text;
            email = txtEmail.Text;
            telefone = txtTelefone.Text;
            celular = txtCelular.Text;
            cidade = cbbCidade.Items[cbbCidade.SelectedIndex].ToString();
            estado = cbbEstado.Items[cbbEstado.SelectedIndex].ToString();
            if(rdbCasado.Checked == true)
            {
                estadoCivil = "casado";
            }
            else
            {
                estadoCivil = "solteiro";
            }

            if(chbFundamental.Checked == true)
            {
                escolaridade = " Ensino Fundamental ";
            }else if (chbMedio.Checked == true)
            {
                escolaridade = " Ensino Médio ";
            }
            else
            {
                escolaridade = " Ensino Superior ";
            }

            GravarFuncionario(nome, email, telefone, celular, cidade, estado, estadoCivil, escolaridade);
            MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Limpartela();

        }

        private void GravarFuncionario(string nome, string email, string telefone, string celular, 
            string cidade, string estado, string estadCivil, string escolaridade)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\funcionarios.text";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone(s): "+ telefone + " " + celular);
            arquivo.WriteLine("Local: " + cidade + " (" + estado + ") ");
            arquivo.WriteLine("Estado Civil: " + estadCivil);
            arquivo.WriteLine("Escolaridade? " + escolaridade);
            arquivo.WriteLine("===================================================");
            arquivo.WriteLine();
            arquivo.WriteLine();
            arquivo.Close();
        }

        private void Limpartela()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtSalario.Text = "";
            txtTelefone.Text = "";
            cbbCidade.Text = "";
            cbbEstado.Text = "";
            rdbCasado.Checked = false;
            rdbSolteiro.Checked = false;
            chbFundamental.Checked = false;
            chbMedio.Checked = false;
            chbSuperior.Checked = false;
        }
    }
}
