using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Classes
{
    internal class Manager : Employee
    {
        private double bonus;
        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public Manager(string name, double salary, double bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public override string Print()
        {
            return $"{base.Print()}\nBonus: {bonus}";
        }
    }
}
