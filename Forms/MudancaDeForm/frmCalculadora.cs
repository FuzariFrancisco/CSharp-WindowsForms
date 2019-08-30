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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Soma(Convert.ToDouble(txtNumero1.Text), 
                Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Subtracao(Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Divisao(Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text))).ToString();
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (Multiplicacao(Convert.ToDouble(txtNumero1.Text),
                Convert.ToDouble(txtNumero2.Text))).ToString();
        }


        private double Soma(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 + Num2;
            return Resultado;
        }
        private double Subtracao(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 - Num2;
            return Resultado;
        }
        private double Multiplicacao(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 * Num2;
            return Resultado;
        }
        private double Divisao(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 / Num2;
            return Resultado;
        }
    }
}
