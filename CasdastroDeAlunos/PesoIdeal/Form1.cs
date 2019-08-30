using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        RadioButton rdbSlecionado = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void gpbSexo_Enter(object sender, EventArgs e)
        {

        }

        private void rdbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double PesoIdeal = 0;

                if(rdbMasculino.Checked == true)
                {
                    PesoIdeal = (72.7 * altura) - 58;
                    lblPesoIdeal.Text = PesoIdeal.ToString();
                }
                else if (rdbFeminino.Checked == true)
                {
                    PesoIdeal = (62.1 * altura) - 44.7;
                    lblPesoIdeal.Text = PesoIdeal.ToString();
                }
                else
                {
                    lblPesoIdeal.Text = "0";
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Informe a altura corretamente e selecione um sexo", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }
}
