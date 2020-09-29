using System;
using System.Collections.Generic;
using System.Text;

namespace Mod2_Lab3
{
    abstract class Person
    {
        public virtual string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }

    }
}
