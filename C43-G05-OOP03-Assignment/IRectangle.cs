﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03_Assignment
{
    internal interface IRectangle :IShape
    {
        double Width { get; set; }
        double Height { get; set; }
    }
}