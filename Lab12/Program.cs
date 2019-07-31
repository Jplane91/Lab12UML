using System;
using System.Collections.Generic;

namespace Lab12
{
    class Program
    {
        public static List<Person> peopleList = new List<Person>

            {
                new Student("Criminal Science", 2, 4500, "Katie", "8313 Washington Road"),
                new Student("Pre-Med", 2, 8000, "Steven", "515 Madison Drive"),
                new Student("Business", 2, 6500, "Jake", "123 Michigan Avenue"),
                new Staff("University of Michigan", 80000, "Doris", "313 Potter Road"),
                new Staff("University of Michigan", 75000, "Matthew", "7314 Main Road"),

            };
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                PrintPersonList(peopleList);
                AddToList(peopleList);

            }
        }

        public static void PrintPersonList(List<Person> list)
        {
            Console.WriteLine("List of Students and Staff:\n");
            Console.WriteLine("STUDENT LIST");
            foreach (var item in list)
            {

                var students = item as Student;
                if (students != null)
                {
                    string studentList = item.ToString();
                    Console.WriteLine("\n" + studentList);
                }

            }

            Console.WriteLine("STAFF LIST");
            foreach (var item1 in list)
            {
                var staff = item1 as Staff;
                if (staff != null)
                {
                    string staffList = item1.ToString();
                    Console.WriteLine("\n" + staffList);
                }
            }
        }

        public static void AddToList(List<Person> list)
        {
            bool addToList = true;
            while (addToList)
            {
                Console.WriteLine("Would you like to enter a Staff or Student?");
                string addResponse = Console.ReadLine().ToLower();
                if (addResponse == "staff")
                {
                    Staff staffInfo = new Staff();

                    Console.WriteLine("Enter School");
                    staffInfo.School = Console.ReadLine();

                    Console.WriteLine("Enter Pay");
                    staffInfo.Pay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name");
                    staffInfo.Name = Console.ReadLine();

                    Console.WriteLine("Enter Address");
                    staffInfo.Address = Console.ReadLine();

                    Program.peopleList.Add(staffInfo);
                    Console.Clear();
                    break;


                }

                else if (addResponse == "student")
                {
                    Student studentInfo = new Student();

                    Console.WriteLine("Enter Their Program");
                    studentInfo.Program = Console.ReadLine();

                    Console.WriteLine("Enter Their Year");
                    studentInfo.Year = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Fee");
                    studentInfo.Fee = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Name");
                    studentInfo.Name = Console.ReadLine();

                    Console.WriteLine("Enter Address");
                    studentInfo.Address = Console.ReadLine();

                    Program.peopleList.Add(studentInfo);

                    Console.WriteLine("Hit any key to continue");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    addToList = true;
                }

                Console.Clear();
            }
        }


    }
}
