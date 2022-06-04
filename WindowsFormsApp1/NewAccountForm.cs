using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string nationalID = nidBox.Text;
            string address = addressBox.Text;
            string phonenumber = phonenumberBox.Text;
            string work = workingdirectionBox.Text;
            int accounttype;
            if (fixedRadio.Checked)
                accounttype = 0;
            if (savingsRadio.Checked)
                accounttype = 1;
        }
    }
}
