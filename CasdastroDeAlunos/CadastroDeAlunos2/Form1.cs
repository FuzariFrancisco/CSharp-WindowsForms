using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAlunos2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblDataDeHoje.Text = "Hoje: " + DateTime.Now.ToShortDateString(); 
        }

        private void btnExibeCategoria_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == String.Empty)
            {
                MessageBox.Show("O nome não pode ser em branco.", "Atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                TimeSpan tsQuantidadeDeDias = DateTime.Now.Date - dtpDataDeNascimento.Value;
                int idade = (tsQuantidadeDeDias.Days / 365);

                if(idade > 17)
                {
                    lblExibeCategoria.Text = "Adulto";
                }
                else if (idade > 13)
                {
                    lblExibeCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    lblExibeCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    lblExibeCategoria.Text = "Infantil B";
                }
                else if (idade >= 5)
                {
                    lblExibeCategoria.Text = "Infantil A";
                }
                else
                {
                    lblExibeCategoria.Text = "Não existe categoria";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
