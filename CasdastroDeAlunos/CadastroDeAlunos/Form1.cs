using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(txtAnoNascimento.Text.Length != 4)
            {
                MessageBox.Show("Informe o ano corretamente","Atenção",MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtAnoNascimento.Focus();
            }
        }

        private void txtAnoAniversario_Validating(object sender, CancelEventArgs e)
        {

            if(txtAnoAniversario.Text == String.Empty || 
               Convert.ToInt32(txtAnoNascimento.Text) > Convert.ToInt32(txtAnoAniversario.Text))
            {
                MessageBox.Show("O ano de nascimento tem que ser menor que o ano do último aniversário",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }

        }

        private void txtAnoAniversario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty)
            {
                MessageBox.Show("O nome não pode ser vazio", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
            }
            else
            {
                int idade = Convert.ToInt32(txtAnoAniversario.Text) - Convert.ToInt32(txtAnoNascimento.Text);

                if(idade > 17)
                { lblExibeCategoria.Text = "Adulto"; }
                else if ( idade > 13)
                { lblExibeCategoria.Text = "Juvenil B"; }
                else if (idade > 10)
                { lblExibeCategoria.Text = "Juvenil A"; }
                else if (idade > 7)
                { lblExibeCategoria.Text = "Infantil B"; }
                else if (idade >= 5)
                { lblExibeCategoria.Text = "Infantil A"; }
                else
                { lblExibeCategoria.Text = "Não existe categoria"; }
            }
        }
    }
}
