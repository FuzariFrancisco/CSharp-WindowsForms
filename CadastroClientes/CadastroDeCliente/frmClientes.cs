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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string vegano, lactose, diabetico, estadoCivil, vegetariano;

            if(chbDiabetico.Checked == true)
            {
                diabetico = "Sim";
            }
            else { diabetico = "Não"; }

            if (chbVegano.Checked == true)
            {
                vegano = "Sim";
            }
            else { vegano = "Não"; }

            if (chbVegetariano.Checked == true)
            {
                vegetariano = "Sim";
            }
            else { vegetariano = "Não"; }

            if (chbIntolerante.Checked == true)
            {
                lactose = "Sim";
            }
            else { lactose = "Não"; }

            if(rdbCasado.Checked == true)
            {
                estadoCivil = "Casado";
            }else if (rdbSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro";
            }
            else
            {
                estadoCivil = "";
            }

            GravarCliente(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCelular.Text,
                cbbCidade.Items[cbbCidade.SelectedIndex].ToString(), cbbEstado.Items[cbbEstado.SelectedIndex].ToString(),
                estadoCivil, vegetariano, vegano, lactose, diabetico);

            MessageBox.Show("Cliente gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GravarCliente(string nome, string email, string telefone, 
            string celular, string cidade, string estado, string estadoCivil, string vegetariano, 
            string vegano, string lactose, string diabetico)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\clientes.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("email: " + email);
            arquivo.WriteLine("telefone: " + telefone);
            arquivo.WriteLine("celular: " + celular);
            arquivo.WriteLine("cidade: " + cidade);
            arquivo.WriteLine("estado: " + estado);
            arquivo.WriteLine("estado civil: " + estadoCivil);
            arquivo.WriteLine("vegetariano? " + vegetariano);
            arquivo.WriteLine("vegano? " + vegano);
            arquivo.WriteLine("intolerancia á lactose? " + lactose);
            arquivo.WriteLine("diabético? " + diabetico);
            arquivo.WriteLine("=======================================================");
            arquivo.WriteLine("");
            arquivo.WriteLine("");
            arquivo.Close();    
        }

        private void LimparTela()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            cbbCidade.Text = "";
            cbbEstado.Text = "";
            rdbCasado.Checked = false;
            rdbSolteiro.Checked = false;
            chbDiabetico.Checked = false;
            chbIntolerante.Checked = false;
            chbVegano.Checked = false;
            chbVegetariano.Checked = false;

        }
    }
}
