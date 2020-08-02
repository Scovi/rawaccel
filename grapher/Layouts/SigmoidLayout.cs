﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grapher.Layouts
{
    public class SigmoidLayout : LayoutBase
    {
        public SigmoidLayout()
            : base()
        {
            Name = "Sigmoid";
            Index = 5;
            ShowOptions = new bool[] { true, true, true, true }; 
            OptionNames = new string[] { Offset, Acceleration, Limit, Midpoint }; 
        }
    }
}