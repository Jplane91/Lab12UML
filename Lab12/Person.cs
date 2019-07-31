using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person()
        {

        }
        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }
     
        public override string ToString()
        {
            string nameAndAddress = "Person\nName: " + Name + "\nDddress: " + Address;
            return nameAndAddress;
        }
    }
}