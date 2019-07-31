using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }
      
        public Staff() : base()
        {

        }
        public Staff(string school, double pay, string name, string address)
            : base(name, address)
        {
            School = school;
            Pay = pay;

        }
        public override string ToString()
        {
            string staffInfo = "Person\nName: " + Name + "\nAddress: " + Address + "\nSchool: " + School +
                "\nPay: " + Pay;
            return staffInfo;

        }
    }
}