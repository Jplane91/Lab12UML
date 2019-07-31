using System;


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
            string staffInfo = "\tPerson\n\tName: " + Name + "\n\tAddress: " + Address + "\n\tSchool: " + School +
                "\n\tPay: " + Pay;
            return staffInfo;

        }

        internal static void Add(string addSchool, int addPay, string addName, string addAddress)
        {
            throw new NotImplementedException();
        }
    }
}