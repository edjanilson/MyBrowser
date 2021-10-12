using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void navegar()
        {
            if (txtURL.Text != "")
            {

                webBrowser1.Navigate(txtURL.Text);
            }
            else
            {
                MessageBox.Show("Digite um endereço e tente novamente.");
                txtURL.Focus();
            }
        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            navegar();
        }

        private void txtURL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                navegar();
            }
        }
    }
}
