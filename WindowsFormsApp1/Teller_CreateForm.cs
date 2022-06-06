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
    public partial class Teller_CreateForm : Form
    {
        private int id;
        public Teller_CreateForm()
        {
            InitializeComponent();
        }
        public Teller_CreateForm(int n, string x)
        {
            InitializeComponent();
            userlabel.Text = x;
            id = n;
        }

        private void createaccountbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameBox.Text;
                string nationalID = nidBox.Text;
                string address = addressBox.Text;
                string phonenumber = phonenumberBox.Text;
                string work = workingdirectionBox.Text;
                int accounttype;
                if (fixedRadio.Checked == true)
                { accounttype = 0; }
                else { accounttype = 1; }
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                Teller teller = new Teller();
                int id = teller.CreateUser(username, password, name, nationalID, address, phonenumber, work, accounttype);


                MessageBox.Show(id + "");
                AccountIDForm accountIDForm = new AccountIDForm(id);
                this.Hide();
                accountIDForm.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "enter valid data");

                nameBox.Clear();
                nidBox.Clear();
                addressBox.Clear();
                phonenumberBox.Clear();
                workingdirectionBox.Clear();
                usernameBox.Clear();
                passwordBox.Clear();
                fixedRadio.Checked = false;
                savingsRadio.Checked = false;

            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Teller_Form teller_Form = new Teller_Form();
            this.Hide();
            teller_Form.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
