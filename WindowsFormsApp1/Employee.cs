using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Employee : Person
    {
        private decimal Salary;
        private string ID;

        public decimal salary
        {
            set { Salary = value; }
            get { return Salary; }
        }
        public string iD
        {
            set { ID = value; }
            get { return ID; }
        }

        public Employee()
        {

        }
        public Employee(string name, string nationalID, string address, string phoneNumber, decimal salary, string iD):base(name, nationalID, address, phoneNumber)
        {
            Salary = salary;
            ID = iD;
        }
    }
}
