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
    public partial class User_Form : Form
    {
        private int id = 0;
        private string name = "";
        public User_Form()
        {
            InitializeComponent();
        }
        public User_Form(int n)
        {
            InitializeComponent();
            id = n;

            User user = new User();
            name = user.GetName(id);
            

            BalanceRadio.Checked = false;
            DepositeRadio.Checked = false;
            WithdrawRadio.Checked = false;
            TransfereRadio.Checked = false;
        }

        private void proceedbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (BalanceRadio.Checked)
                {
                    User_BalanceForm user_BalanceForm = new User_BalanceForm(id,name);
                    this.Hide();
                    user_BalanceForm.Show();
                }
                else if (DepositeRadio.Checked)
                {
                    User_DepositeForm user_DepositeForm = new User_DepositeForm(id, name);
                    this.Hide();
                    user_DepositeForm.Show();
                }
                else if (WithdrawRadio.Checked)
                {
                    User_WithdrawForm user_WithdrawForm = new User_WithdrawForm(id, name);
                    this.Hide();
                    user_WithdrawForm.ShowDialog();
                }
                else if (TransfereRadio.Checked)
                {
                    User_TransfereForm user_TransfereForm = new User_TransfereForm(id, name);
                    this.Hide();
                    user_TransfereForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select operation");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }
    }
}
