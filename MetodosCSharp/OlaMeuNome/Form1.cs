using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMeuNome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Nome(string nome)
        {
            if(nome == String.Empty)
            {
                MessageBox.Show("Nome é Obrigatório", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Olá meu nome é " + nome, "Nome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Nome(txtNome.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
