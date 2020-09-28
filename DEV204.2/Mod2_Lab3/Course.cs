using System;
using System.Collections.Generic;
using System.Text;
using Mod2_Lab3;

namespace UniApp_Mod1
{
    class Course
    {
        private readonly LinkedList<Student> _students;
        private readonly LinkedList<Teacher> _teachers;

        public string Name { get; set; }
        public Course()
        {
            _students = new LinkedList<Student>();
            _teachers = new LinkedList<Teacher>();
        }

        public Course(string courseName) : this()
        {
            Name = courseName;
        }

        public void AddStudentAll(params Student[] aStudent)
        {
            foreach (var student in aStudent)
            {
                _students.AddLast(student);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.AddLast(teacher);
        }

        public int GetNumStudent()
        {
            return _students.Count;
        }
    }
}
