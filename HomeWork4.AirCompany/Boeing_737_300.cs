﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4.AirCompany
{
    public class Boeing_737_300 : AirCompany
    {
        public Boeing_737_300(string name, double capacity, double carrying, double range)
        {
            Name = name;
            Capacity = capacity;
            Carrying = carrying;
            Range = range;
        }
    }
}
