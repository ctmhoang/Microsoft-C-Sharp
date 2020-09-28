using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mod2_Lab2
{
    public abstract class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }
            set
            {
                employeeBaseSalary = value;
            }
        }

        private static int employeeCount = 1;

        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }

        public Employee(string name, double salary)
        {
            Name = name;
            BaseSalary = salary;
            ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return BaseSalary;
        }

        public string getName()
        {
            return Name;
        }

        public int getEmployeeID()
        {
            return ID;
        }

        public override string ToString()
        {
            return ID + " " + Name;
        }

        public abstract string employeeStatus();
    }
}
