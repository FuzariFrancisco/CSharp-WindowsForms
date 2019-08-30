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
    public partial class frmNomeVazio : Form
    {
        public frmNomeVazio()
        {
            InitializeComponent();
        }

        public void btnFechar_Click(object sender, EventArgs e)
        {
                Close();
        }
        
    }
}
