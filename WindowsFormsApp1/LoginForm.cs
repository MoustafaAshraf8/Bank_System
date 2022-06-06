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
            SqlDataReader dtrr = null;
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {

                    string query = "select * from AccessInfo where Username='" + usernameBox.Text.ToString() + "' and Password= '" + passwordBox.Text.ToString() + "'";
                   
                    SqlCommand cmd = new SqlCommand(query, conn);
                    dtrr = cmd.ExecuteReader();
                    Console.WriteLine(dtrr);
                    if (dtrr.Read())
                    {
                        
                        int id = Convert.ToInt32(dtrr.GetValue(0));
                        int level = Convert.ToInt32(dtrr.GetValue(3));
                        
                        if (level == 1)
                        {

                            User_Form user_Form = new User_Form(id);
                            this.Close();
                            user_Form.ShowDialog();
                        }

                        else if (level == 15)
                        {

                            Teller_Form teller_Form = new Teller_Form(id);
                            MessageBox.Show(Convert.ToString(level));
                            this.Close();
                            teller_Form.ShowDialog();
                        }
                        else
                            MessageBox.Show("invalid username or password");

                        

                    }

                    else
                    {

                        MessageBox.Show("invalid username and password","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        usernameBox.Clear();
                        passwordBox.Clear();
                        usernameBox.Focus();
                    }
                    
                    

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
                MessageBox.Show(ex.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            finally
            {
                dtrr.Close();
                conn.Close();
            }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
