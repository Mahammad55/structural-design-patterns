﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.proxy
{
    internal class RealInternet : Internet
    {
        public void ConnectTo(string host)
        {
            Console.WriteLine($"Connection opening to: {host}");
        }
    }
}
