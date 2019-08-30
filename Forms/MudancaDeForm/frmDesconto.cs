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
    public partial class frmDesconto : Form
    {
        public frmDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (Desconto(Convert.ToDouble(txtValor.Text),
                Convert.ToDouble(txtAcrescimo.Text))).ToString();
        }

        private double Desconto(double valor, double taxa)
        {
            double total;
            total = valor - valor * (taxa / 100);
            return total;
        }


    }
}
