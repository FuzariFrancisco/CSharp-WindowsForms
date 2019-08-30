using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (rdbMais.Checked == true)
            {
                txtResultado.Text = Convert.ToString(Somar(Convert.ToDouble(txtNumero1.Text),
                    Convert.ToDouble(txtNumero2.Text)));
            }
            else if (rdbMenos.Checked == true)
            {
                txtResultado.Text = Convert.ToString(Subtrair(Convert.ToDouble(txtNumero1.Text),
                    Convert.ToDouble(txtNumero2.Text)));
            }
            else if (rdbDivisao.Checked == true)
            {
                txtResultado.Text = Convert.ToString(Dividir(Convert.ToDouble(txtNumero1.Text),
                    Convert.ToDouble(txtNumero2.Text)));
            }
            else if (rdbMultiplicacao.Checked == true)
            {
                txtResultado.Text = Convert.ToString(Multiplicar(Convert.ToDouble(txtNumero1.Text),
                    Convert.ToDouble(txtNumero2.Text)));
            }
        }

        private double Somar(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 + Num2;
            return Resultado;
        }

        private double Subtrair(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 - Num2;
            return Resultado;
        }

        private double Dividir(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 / Num2;
            return Resultado;
        }

        private double Multiplicar(double Num1, double Num2)
        {
            double Resultado;
            Resultado = Num1 * Num2;
            return Resultado;
        }
    }
}
