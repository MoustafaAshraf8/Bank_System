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
        public static int CreateUser(string username, string password, string name, string nationalID, string address, string phonenumber, string WorkDirection, int accounttype)
        {
            int id = 0;
            //isert the username and password into the AccessInfo table

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            con.Open();

            try
            {
                if (con.State == System.Data.ConnectionState.Open)

                {
                    string query = "INSERT INTO AccessInfo (Username, Password, Level) VALUES ('" + username.ToString() + "','" + password.ToString() + "','"+1+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();

                    /*string query2 = "SELECT id_Randome FROM AccessInfo WHERE Username ='" +username+"'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    */
                    
                    //string query2 = "select * from AccessInfo where Username = '" + username;

                    string query2 = "SELECT * FROM AccessInfo WHERE Username = '"+username.ToString()+"'and Password = '"+password.ToString()+"'";
                    SqlCommand command = new SqlCommand(query2, con);
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        id = (int)dataReader.GetValue(0);
                        
                    }
                    dataReader.Close();

                    //SqlDataReader datareader = cmd2.ExecuteReader();
                    //int id = (int)datareader.GetValue(0);
                    //datareader.Close();

                    string query3 = "INSERT INTO PersonTable (id_Person, Name, NarionalID, Address, PhoneNumber) VALUES ('" + (int)id + "','" + name.ToString() + "','" + nationalID.ToString() + "','" + address.ToString() + "','" + phonenumber.ToString() + "')";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    cmd3.ExecuteNonQuery();

                    Random rand = new Random();
                    string accountid = (char)rand.Next(65,91) + (char)rand.Next(97, 123) + id*2 + (char)rand.Next(97, 123) + (char)rand.Next(65, 91)+"";


                    string query4 = "INSERT INTO UserTable (id_User, WorkingDirection,AccountType,AccountID) VALUES ('" + (int)id + "','" + WorkDirection.ToString() + "','" + (int)accounttype + "','"+accountid.ToString()+ "')";
                    SqlCommand cmd4 = new SqlCommand(query4, con);
                    cmd4.ExecuteNonQuery();
                    
                    con.Close();

                }

                else
                {
                    Teller_BalanceForm teller_BalanceForm = new Teller_BalanceForm();
                    teller_BalanceForm.ShowDialog();

                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return id;
            

        }
        public static void DeleteUser(int ID1)
        {

        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static decimal ShowBalance(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
                con.Open();

                string query = "select * from UserTable where id_User=" + id;
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    return (decimal)dtr.GetValue(2);
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine (ex.Message);
                return 0;
            }
        }
        public static void Depositeuser(int id)
        {
            
        }
        public static void Withdrawuser(int id)
        {
           
        }
        public static void Transfereuser(int id)
        {
            
        }

        public static string GetName(int id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Moustafa\Desktop\BankSystem\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            conn.Open();
            string query = "select * from PersonTable where id_Person=" + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader dtr = cmd.ExecuteReader();
            if (dtr.Read())
            {
                return (string)dtr.GetValue(1);
            }

            else return "abcdef";
        }
    }
}
