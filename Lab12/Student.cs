using System;

namespace Lab12
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student() : base()
        {

        }
        public Student(string program, int year, double fee, string name, string address)
            : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }
      
        public override string ToString()
        {
            string studentInfo = "\tPerson\n\tName: " + Name + "\n\tAddress: " + Address + "\n\tProgram: " + Program +
                "\n\tYear: " + Year + "\n\tFee: " + Fee;
            return studentInfo;
        }

    }
}