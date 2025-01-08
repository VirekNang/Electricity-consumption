using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Electricity.Forms
{
    public partial class FormMain : Form
    {
      FormReceivePayment formReceivePayment;
        FormManageCustomer formManageCustomer;
        FormConnectionFee formConnectionFee;
       
        public FormMain()
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
                pnMainPostpay.Controls.Add(formReceivePayment);
                form.ShowDialog();

            }
        }
        private void pnReceivepayment_Click(object sender, EventArgs e)
        {
            OpenFrom(new FormReceivePayment(), "FormReceivePayment");
            //FormReceivePayment formReceivePayment =new FormReceivePayment();
            //formReceivePayment.TopLevel=false;
            //pnMainPostpay.Controls.Add(formReceivePayment);

            //formReceivePayment.Show();
            //formReceivePayment.WindowState = WindowState;
            //formReceivePayment.BringToFront();
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsExit_MouseHover(object sender, EventArgs e)
        {
            tslblExite.ForeColor = Color.Red;
        }

        private void tsExit_MouseLeave(object sender, EventArgs e)
        {
            tslblExite.ForeColor=Color.Black;
        }

        private void tsMaximize_Click(object sender, EventArgs e)
        {
            
        }

        private void tsCloseApplication_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnManageCustomer_Click(object sender, EventArgs e)
        {

            lblTitleCustomerandpayment.Text = lblManageCustomer.Text;
            if (formManageCustomer == null)
            {
                formManageCustomer = new FormManageCustomer();
                formManageCustomer.TopLevel = false;
                pnMainCustomer.Controls.Add(formManageCustomer);
                formManageCustomer.Show();
                formManageCustomer.BringToFront();

            }
            else
            {
                formManageCustomer.BringToFront();
            }

        }

        private void pnDeleteReceivePayment_Click(object sender, EventArgs e)
        {
            OpenFrom(new FormDeletePayment(), "FormDeletePayment");
        }

        private void pnRegister_Click(object sender, EventArgs e)
        {
           
            lblTitleCustomerandpayment.Text = lblRegister.Text;
 
            OpenFrom(new FormRegisterCustomer(), "FormRegisterCustomer");

        }

        private void lblInputRading_Click(object sender, EventArgs e)
        {
            OpenFrom(new FormConsumption(), "FormConsumption");      
        }

        private void tsCloseApplication_MouseHover(object sender, EventArgs e)
        {
            tsCloseApplication.ForeColor=Color.White;
        }

        private void tsCloseApplication_MouseLeave(object sender, EventArgs e)
        {
            tsCloseApplication.ForeColor = Color.Black;
        }

        private void បកToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pnTurnOffAc_Click(object sender, EventArgs e)
        {
            //string testValue = "Test";

            //// Create an instance of FormRegisterCustomer
            //FormRegisterCustomer formRegisterCustomer = new FormRegisterCustomer();

            //// Set the value of Test1 in FormRegisterCustomer
            //formRegisterCustomer.Test1 = testValue;

            //// Configure FormRegisterCustomer to be a child of pnMain
            //formRegisterCustomer.TopLevel = false;
            //formRegisterCustomer.Dock = DockStyle.Fill; // Optional: Fill the parent panel
            //pnMainCustomer.Controls.Add(formRegisterCustomer); // Add the form to pnMain

            //// Show the form
            //formRegisterCustomer.Show();
            //formRegisterCustomer.BringToFront(); ;
        }

        private void pnCostConnectAc_Click(object sender, EventArgs e)
        {
            if (formConnectionFee == null)
            {
                formConnectionFee = new FormConnectionFee();
                formConnectionFee.TopLevel=false;
                pnMainCustomer.Controls.Add(formConnectionFee);
                formConnectionFee.Show();
                formConnectionFee.BringToFront();
            }
            else
            {
                formConnectionFee.BringToFront();
            }
        }
    }
}
