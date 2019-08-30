using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReajuste_Click(object sender, EventArgs e)
        {
            double ajustado = reajuste(Convert.ToDouble(txtSalario.Text));
            MessageBox.Show("Sálario reajustado é R$ " + ajustado);
        }

        private double reajuste(double salario)
        {
           
            if(salario > 200 && salario < 1700)
            { salario = salario + 300; }
            return salario;
        }
    }
}
