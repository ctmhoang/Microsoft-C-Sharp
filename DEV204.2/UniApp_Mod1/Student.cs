using System;
using System.Collections.Generic;
using System.Text;

namespace UniApp_Mod1
{
    class Student
    {
        public string Name { get; set; }

        public static int CurrentStudents { get; private set; } = 0;

        public Student()
        {
            CurrentStudents++;
        }

        public Student(string name):this()
        {
            Name = name;
        }
    }
}
