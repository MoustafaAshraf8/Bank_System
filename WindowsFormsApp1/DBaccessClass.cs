using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    static class DBaccessClass
    {
        
        public static void AddDeposite(int ID)
        {

        }
        public static void Withdraw(int ID)
        {

        }
        public static void Transfere(int ID1, int ID2)
        {

        }
        public static void CheckBalance(int ID1)
        {

        }
        public static void CreateUser(string username, string password, string name, string nationalID, string address, string phonenumber, string WorkDirection, int accounttype)
        {
                    //isert the username and password into the AccessInfo table
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-GDMHNN6K\SQLEXPRESS;Initial Catalog=BankDB;Integrated Security=True");
            string query = "INSERT INTO AccessInfo (Username, Password) VALUES ('"+username+"','"+password+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();

            query = "SELECT id_Randime FROM AccessInfo WHERE Username = username";
            cmd = new SqlCommand(query, con);
            SqlDataReader datareader = cmd.ExecuteReader();
            var id = datareader.GetValue(0);
            datareader.Close();

            query = "INSERT INTO PersonTable (id_Person, Name, NationalID, Address, PhoneNumber) VALUES ('" + id + "','" + name + "','"+nationalID+"','"+address+"','"+phonenumber+"')";
            cmd = new SqlCommand(query,con);
            cmd.ExecuteNonQuery();

            query = "INSERT INTO UserTable (id_User, WorkingDirectio, Address, AccountType) VALUES ('" + id + "','" + WorkDirection + "','" + accounttype +"')";
            cmd = new SqlCommand (query,con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        public static void DeleteUser(int ID1)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static void ShowBalance(int ID)
        {

        }
        public static void Depositeuser(int ID)
        {
            
        }
        public static void Withdrawuser(int ID)
        {
           
        }
        public static void Transfereuser(int ID)
        {
            
        }
    }
}
