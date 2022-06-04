using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Person
    {
        private string Name;
        private string NationalID;
        private string Address;
        private string PhoneNumber;

        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public string nationalID
        {
            set { NationalID = value; }
            get { return NationalID;}
        }
        public string address
        {
            set { Address = value; }
            get { return Address;}
        }
        public string phoneNumber
        {
            set { PhoneNumber = value; }
            get { return PhoneNumber;}
        }

        public Person()
        {

        }
        public Person(string name, string nationalID, string address, string phoneNumber)
        {
            Name = name;
            NationalID = nationalID;
            Address = address;
            PhoneNumber = phoneNumber;
        }



    }
}
