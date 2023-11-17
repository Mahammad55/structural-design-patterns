using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.adapter
{
    internal class Volt
    {
        private readonly int volts;

        public Volt(int volts)
        {
            this.volts = volts;
        }

        public int GetVolts()
        {
            return volts;
        }

        public override string ToString()
        {
            return $"Volt [volts = {this.volts}]";
        }
    }
}
