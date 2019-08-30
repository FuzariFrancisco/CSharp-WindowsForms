using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MudancaDeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 101; i++)
            {
                progressBar1.Value = i;
            }

            Form2 f2 = new Form2();
             f2.Show();
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            frmAcrescimo f2 = new frmAcrescimo();
            f2.Show();
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            frmDesconto f2 = new frmDesconto();
            f2.Show();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            frmCalculadora f2 = new frmCalculadora();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
         
        }
        
    }
}
