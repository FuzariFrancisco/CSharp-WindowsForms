using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            Exibir();
        }

        private void Exibir()
        {

            MessageBox.Show("Olá, Mundo. Projeto no Visual Studio!\n " +
                "A execução acabou. Tecle enter para finalizar...", "Mensagem", MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
            
        }
    }
}
