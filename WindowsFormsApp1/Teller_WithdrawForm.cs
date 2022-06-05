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
    public partial class Teller_WithdrawForm : Form
    {
        private int id;
        public Teller_WithdrawForm()
        {
            InitializeComponent();
        }
        public Teller_WithdrawForm(int n, string x)
        {
            InitializeComponent();
            userlabel.Text = x;
            id = n;
        }


        
    }
}
