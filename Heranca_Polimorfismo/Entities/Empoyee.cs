using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_Polimorfismo.Entities
{
    class Empoyee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Empoyee()
        {
        }

        public Empoyee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }

 
}
