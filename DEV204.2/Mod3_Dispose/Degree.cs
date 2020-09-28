using System;
using System.Collections.Generic;
using System.Text;

namespace UniApp_Mod1
{
    class Degree
    {
        private readonly LinkedList<Course> _courses;

        public string Type { get; set; }

        public Degree()
        {
            _courses = new LinkedList<Course>();
        }

        public Degree(string type):this()
        {
            Type = type;
        }

        public void Add(Course course)
        {
            _courses.AddLast(course);
        }
    }
}
