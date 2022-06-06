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
    public partial class User_BalanceForm : Form
    {
        public User_BalanceForm()
        {
            InitializeComponent();
        }
        public User_BalanceForm(int n,string x)
        {
            InitializeComponent();
            userlabel.Text = x;
            User user = new User();
            ballanceBox.Text = "$" + user.ShowBalance(n);

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            User_Form user_Form = new User_Form();
            this.Hide();
            user_Form.ShowDialog();
        }
    }
}
