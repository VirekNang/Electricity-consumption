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
    public partial class FormManageCustomer : Form
    {
        public FormManageCustomer()
        {
            InitializeComponent();
        }
        void OpenFrom(Form form, string tt)
        {
            bool isopen = false;
            foreach (Form form1 in Application.OpenForms)
            {
                if (form1.Text == tt)
                {
                    isopen = true;
                    form.Focus();
                }
            }
            if (isopen == false)
            {
         
                form.ShowDialog();

            }
        }

        private void picExit_Click(object sender, EventArgs e)
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

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFrom(new FormMnangeCustomerAddUpdateDeleteprintInvoice(), "FormMnangeCustomerAddUpdateDeleteprintInvoice");
        }
    }
}
