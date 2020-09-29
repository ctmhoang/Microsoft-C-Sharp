using System;
using Mod2_Lab3;

namespace UniApp_Mod1
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Mark");
            var s2 = new Student("Cam");
            var s3 = new Student("Alan");
            var course = new Course("Programming with C#");
            course.AddStudentAll(s1, s2, s3);
            var teacher = new Teacher("Rowan");
            course.AddTeacher(teacher);
            var deg = new Degree("Bachelor");
            deg.Add(course);

            var itProgram = new UProgram("Information Technology");

            itProgram.Add(deg);

            Console.WriteLine($"Program {itProgram.Name} contains {deg.Type}");
            Console.WriteLine($"Has course {course.Name}");
            Console.WriteLine($"Has {course.GetNumStudent()} students");
        }
    }
}
