﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class User
    {
        private string WorkingDirection;
        private string Salary;
        private decimal Balance;

        public User()
        { }
        public User(string WorkingDirection, string Salary, decimal Balance)
        {
            this.WorkingDirection = WorkingDirection;
            this.Salary = Salary;
            this.Balance = Balance;
        }

        public void ShowBalance(int ID)
        {
            DBaccessClass.ShowBalance(ID);
        }
        public void Depositeuser(int ID)
        {
            DBaccessClass.Depositeuser(ID);
        }
        public void Withdrawuser(int ID)
        {
            DBaccessClass.Withdrawuser(ID);
        }
        public void Transfereuser(int ID)
        {
            DBaccessClass.Transfereuser(ID);
        }

    }
}