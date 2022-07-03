using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.AirCompany
{
    public class Boeing_737_800 : AirCompany
    {
        public Boeing_737_800(string name, double capacity, double carrying, double range)
        {
            Name = name;
            Capacity = capacity;
            Carrying = carrying;
            Range = range;
        }
    }
}
