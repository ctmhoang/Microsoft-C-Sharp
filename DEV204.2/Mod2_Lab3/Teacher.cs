using System;
using System.Collections.Generic;
using System.Text;
using Mod2_Lab3;

namespace UniApp_Mod1
{
    class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
        }

        public void GradeTest()
        {
            Console.WriteLine("Grade Test");
        }
    }
}
