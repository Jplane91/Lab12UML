using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            string studentInfo = "Person\nName: " + Name + "\nAddress: " + Address + "\nProgram: " + Program +
                "\nYear: " + Year + "\nFee: " + Fee;
            return studentInfo;
        }

    }
}