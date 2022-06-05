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
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            this.Hide();
            newAccountForm.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {

                    string query = "select * from AccessInfo where Username='" + usernameBox.Text.ToString() + "'and Password= '" + passwordBox.Text.ToString() + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader dtrr = cmd.ExecuteReader();

                    if (dtrr.Read())
                    {
                        
                        int id = (int)dtrr.GetValue(0);
                        int level = (int)dtrr.GetValue(3);

                        if (level == 1)
                        {
                            User_Form user_Form = new User_Form(id);
                            this.Hide();
                            user_Form.ShowDialog();
                        }
                        else
                        {
                            Teller_Form tell = new Teller_Form(id);
                            this.Hide();
                            tell.ShowDialog();
                        }

                    }

                    else
                    {

                        MessageBox.Show("username and password dont match\nreenter or create a new account");
                        usernameBox.Clear();
                        passwordBox.Clear();
                        usernameBox.Focus();
                    }
                    
                    dtrr.Close();

                }
                else
                {
                    OpenningForm openningForm = new OpenningForm();
                    this.Hide();
                    openningForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            conn.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
