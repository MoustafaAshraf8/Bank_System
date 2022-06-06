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
    
    public partial class Teller_DepositeForm : Form
    {
        private int id;
        public Teller_DepositeForm()
        {
            InitializeComponent();
        }
        public Teller_DepositeForm(int n,string x)
        {
            InitializeComponent();
            userlabel.Text = x;
            id = n;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            conn.Open();
            try
            {
                decimal b = 0;
                string query = "select * from UserTable where AccountID='" + accountBox.Text.ToString()+"'";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dtr = cmd.ExecuteReader();
                if (dtr.Read())
                {
                    
                    b = (decimal)dtr.GetValue(2);
                    

                }
                else
                {
                    MessageBox.Show("didnt get the current balance");
                }

                dtr.Close();

                MessageBox.Show("" + b);
                decimal newbalance = b + decimal.Parse(amountBox.Text.ToString());
                query = "UPDATE UserTable set Balance='" + (decimal)newbalance + "' WHERE AccountID='" + accountBox.Text.ToString() + "'";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("deposite succeed", "successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();
            this.Close();
            user_Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm login_Form = new LoginForm();
            this.Close();
            login_Form.ShowDialog();
        }
    }
}
