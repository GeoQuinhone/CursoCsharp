using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
    class Employee
    {
        public string Name { get; private set; }

        public int Hours { get; private set; }

        public double ValuePerHour { get; private set; }


        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            this.Name = name;
            this.Hours = hours;
            this.ValuePerHour = valuePerHour;
        }

        public virtual double payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
