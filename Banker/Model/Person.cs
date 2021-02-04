using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banker
{
    public class Person
    {
        private string _name;
        private string _surname;
        private string _gender;
        private int _age;
        private int _phoneNumber;
        private string _address;
        [Key]
        public int TCno { get; set; }
        public string name { get { return _name; } set { _name = value; } }
        public string surname { get { return _surname; } set { _surname = value; } }
        public string gender { get { return _gender; } set { _gender = value; } }
        public int age { get { return _age; } set { _age = value; } }
        public int phoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }
        public string address { get { return _address; } set { _address = value; } }

        //public Person( int tc, string name, string surname, string gender, int age, int phoneNumber, string address)
        //{
        //    this.TCno = tc;
        //    this.name = name;
        //    this.surname = surname;
        //    this.phoneNumber = phoneNumber;
        //    this.address = address;
        //}

    }
}
