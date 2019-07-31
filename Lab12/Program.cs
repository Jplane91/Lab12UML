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
            PrintPersonList(peopleList);

        }

        public static void PrintPersonList(List<Person> list)
        {
            Console.WriteLine("List of Students and Staff:\n");
            foreach (var item in list)
            {

                var students = item as Student;
                if (students != null)
                {
                    string studentList = item.ToString();
                    Console.WriteLine("\n" + studentList);
                }

            }

            Console.WriteLine("STAFF");
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
            
    }
}