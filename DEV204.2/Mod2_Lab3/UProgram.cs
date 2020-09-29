using System;
using System.Collections.Generic;
using System.Text;

namespace UniApp_Mod1
{
    class UProgram
    {
        private readonly LinkedList<Degree> _degrees;
        public string Name { get; set; }

        public UProgram()
        {
            _degrees = new LinkedList<Degree>();
        }

        public UProgram(string name) :this()
        {
            Name = name;
        }

        public void Add(Degree deg)
        {
            _degrees.AddLast(deg);
        }
    }
}
