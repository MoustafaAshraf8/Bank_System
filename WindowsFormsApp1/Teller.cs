﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Teller : Employee
    {
        int id = 0;
        private string Position = "Teller";

        public Teller()
        { }
        

        public void Deposite(int ID)
        {
            DBaccessClass.AddDeposite(ID);
        }
        public void Withdraw(int ID)
        {
            DBaccessClass.Withdraw(ID);
        }
        public void Transfere(int ID1, int ID2)
        {
            DBaccessClass.Transfere(ID1, ID2);
        }
        public void Balance(int ID)
        {
            DBaccessClass.CheckBalance(ID);
        }
        public int CreateUser(string username, string password, string name, string nationalID, string address, string phonenumber, string WorkDirection, int accounttype)
        {
            int id = DBaccessClass.CreateUser(username,password,name,nationalID,address,phonenumber,WorkDirection,accounttype);
            return id;
            
        }
        public void DeleteUser(int ID)
        {
            DBaccessClass.DeleteUser(ID);
        }

        public override string GetName(int id)
        {
            return DBaccessClass.GetName(id);
        }




        
    }
}