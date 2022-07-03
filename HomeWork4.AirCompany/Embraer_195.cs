using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.AirCompany
{
    public class Embraer_195 : AirCompany
    {
        public Embraer_195(string name, double capacity, double carrying, double range)
        {
            Name = name;
            Capacity = capacity;
            Carrying = carrying;
            Range = range;
        }
    }
}
