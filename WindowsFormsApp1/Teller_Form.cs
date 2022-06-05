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
    public partial class Teller_Form : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");

        private int id;
        private string name;
        public Teller_Form()
        {
            InitializeComponent();
        }
        public Teller_Form(int n)
        {
            InitializeComponent();
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {

                string query = "select * from PersonTable where id_Person='" + id + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dtrr = cmd.ExecuteReader();
                string x = (string)dtrr.GetString(1);
                label2.Text = x;
                name = x;
            }
            id = n;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            { 
                if(DepositeRadio.Checked == true)
                {
                    Teller_DepositeForm depositeForm = new Teller_DepositeForm(id,name);
                    this.Hide();
                    depositeForm.ShowDialog();
                }
                else if(WithdrawRadio.Checked == true)
                {
                    Teller_WithdrawForm teller_WithdrawForm = new Teller_WithdrawForm(id,name);
                    this.Hide();
                    teller_WithdrawForm.ShowDialog();
                }
                else if(TransfereRadio.Checked == true)
                {
                    Teller_TransfereForm teller_TransfereForm = new Teller_TransfereForm(id,name);
                    this.Hide();
                    teller_TransfereForm.ShowDialog();
                }
                else if(BalanceRadio.Checked == true)
                {
                    Teller_BalanceForm teller_BalanceForm = new Teller_BalanceForm(id,name);
                    this.Hide();
                    teller_BalanceForm.ShowDialog();
                }
                else if(CreateRadio.Checked == true)
                {
                    Teller_CreateForm teller_CreateForm = new Teller_CreateForm(id,name);
                    this.Hide();
                    teller_CreateForm.ShowDialog();
                }
                else if(DeleteRadio.Checked == true)
                {
                    Teller_DeleteForm teller_DeleteForm = new Teller_DeleteForm(id,name);
                    this.Hide();
                    teller_DeleteForm.ShowDialog();
                }
                else
                {
                    errorlabel.Text = "Please select operation";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
