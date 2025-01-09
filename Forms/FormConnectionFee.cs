using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity.Forms
{
    public partial class FormConnectionFee : Form
    {
        public FormConnectionFee()
        {
            InitializeComponent();
        }

        private void picExit1_Click(object sender, EventArgs e)
        {
            picExit1.Visible = false;
            picSearch1.Visible = true;
            txtSearch.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            picSearch1.Visible = false;
            picExit1.Visible = true;
        }
    }
}
