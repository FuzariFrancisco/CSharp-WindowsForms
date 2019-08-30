using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidarIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtIdade.Text == String.Empty)
            {
                SemIdade();
            }
            else if(Convert.ToDouble(txtIdade.Text)<18)
            {
                Menor18();
            }
            else if (Convert.ToDouble(txtIdade.Text) >= 18)
            {
                Maior18();
            }
        }
        public void Maior18()
        {
            frmMaior18 Form = new frmMaior18();
            Form.Show();
        }
        public void Menor18()
        {
            frmMenor18 Form = new frmMenor18();
            Form.Show();
        }
        public void SemIdade()
        {
            frmNomeVazio Form = new frmNomeVazio();
            Form.Show();
        }
    }
}
