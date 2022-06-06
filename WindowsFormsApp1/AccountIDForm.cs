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
    public partial class AccountIDForm : Form
    {
        public AccountIDForm()
        {
            InitializeComponent();
        }

        public AccountIDForm(int n)
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            conn.Open();
            string query = "SELECT * FROM UserTable WHERE id_User =" + n;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dtr = cmd.ExecuteReader();
            if (dtr.Read())
            {
                accountidBox.Text = (string)dtr.GetValue(4);
            }
           dtr.Close();
           conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teller_Form teller_Form = new Teller_Form();
            this.Hide();
            teller_Form.Show();
        }
    }
}
