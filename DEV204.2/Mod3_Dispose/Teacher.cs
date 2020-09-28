using System;
using System.Collections.Generic;
using System.Text;
using Mod2_Lab3;
using Mod3_Dispose;

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

        public override string ToString()
        {
            return Name + " Grade Test";
        }
    }
}
