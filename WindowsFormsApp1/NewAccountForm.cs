using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                teller.CreateUser(username, password, name, nationalID, address, phonenumber, work, accounttype);

                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
                string query = "SELECT * FROM UserTable WHERE Username = '" + username + "'and Password='"+password+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    accountinfoBox.Text = "Account ID : " + dtr.GetValue(4);
                }









                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
            }

            catch(Exception ex)
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

        private void button2_Click(object sender, EventArgs e)
        {
            OpenningForm openningForm = new OpenningForm();
            this.Hide();
            openningForm.ShowDialog();
        }
    }
}
