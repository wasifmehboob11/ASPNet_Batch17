using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private void AddCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddCountry();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
