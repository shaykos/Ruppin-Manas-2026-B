using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    internal class Employee : Person
    {
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
        }

        public override string Print()
        {
            return $"{base.Print()}\nSalary: {salary}";
        }
    }
}
