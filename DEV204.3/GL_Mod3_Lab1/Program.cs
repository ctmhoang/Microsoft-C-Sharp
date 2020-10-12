using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GL_Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            var stud3 = new Student("Mickey", "Mouse", 35, "Animation")
                ;
            var students = new List<Student>
            {
                stud1,
                new Student("Fred", "Flintstone", 45, "Geology"),
                stud3
            };
            foreach (Student stud in students)
            {
                Console.WriteLine(stud.FirstName);
            }

            bool exists = students.Contains<Student>(stud1);
            Console.WriteLine(exists.ToString());
            students.Remove(stud3);
            Console.WriteLine(students.Count());
        }
    }

    class Student
    {
        public Student(string first, string last, int age, string prog)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
            this.Program = prog;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Program { get; set; }
    }
}