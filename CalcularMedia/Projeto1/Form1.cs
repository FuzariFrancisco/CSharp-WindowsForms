using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //ATRIBUI AS TXTMEDIA 1, 2 E 3 PARA A TXTMEDIA FINAL USANDO A OPEÇÃO MATEMÁTICA NECESSÁRIA
            txtMediaFinal.Text = ( (Convert.ToSingle(txtMedia1.Text) +
                                    Convert.ToSingle(txtMedia2.Text) +
                                    Convert.ToSingle(txtMedia3.Text) ) / 3).ToString();
            //CHECA SE A TXTMEDIAFINAL É MAIOR OU MENOR Q 6 E ATRIBUI O EVQUIVALENTE A SEU VALOR NA TXTSITUACAO
            if(Convert.ToSingle(txtMediaFinal.Text) < 6)
            {
                txtSituacao.Text = "Reprovado";
            }
            else
            {
                txtSituacao.Text = "Aprovado";
                txtSituacao.Text = "Aprovado";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMedia1.Text = "";
            txtMedia2.Text = "";
            txtMedia3.Text = "";
            txtMediaFinal.Text = "";
            txtSituacao.Text = "";
        }
    }
}
