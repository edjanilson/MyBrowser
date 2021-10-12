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
    public partial class frmTelaSplash : Form
    {
        public frmTelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCarrega.Value<100)
            {
                pbCarrega.Value = pbCarrega.Value + 4;
            }
            else
                if(pbCarrega.Value==100)
            {
                this.Visible = false;
                timer1.Enabled = false;
                frmPrincipal principal = new frmPrincipal();
                principal.ShowDialog();
            }
        }
    }
}
