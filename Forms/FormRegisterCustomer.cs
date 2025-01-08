using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Electricity.Forms
{
    public partial class FormRegisterCustomer : Form
    {
        public string Test1 { get; set; }
        public FormRegisterCustomer()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Red;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Black;
        }
      

        //private void CheckTestValue()
        //{
        //    // Check the value passed from FormMain
        //    if (Test1 == "Test")
        //    {
        //        // Enable or make tabPage1 visible
        //        if (tbcRegister.TabPages.Contains(tabPage1))
        //        {
        //            tbcRegister.TabPages.Remove(tabPage1); 
        //        }
        //    }
        //    else
        //    {
              
        //        if (tbcRegister.TabPages.Contains(tabPage1))
        //        {
        //            tbcRegister.TabPages.Remove(tabPage1); 
        //        }
        //    }
        //}

        private void FormRegisterCustomer_Load_1(object sender, EventArgs e)
        {
           
        }
    }
 }
