using System;
using Mod3_Dispose;

namespace Mod2_Lab3
{
    class Student : Person
    {

        public static int CurrentStudents { get; private set; } = 0;

        public Student(string name):base(name)
        {
        }

        public void TakeTest()
        {
            Console.WriteLine("Take Test");
        }

        public override string ToString()
        {
            return Name + " Take test";
        }
    }
}
