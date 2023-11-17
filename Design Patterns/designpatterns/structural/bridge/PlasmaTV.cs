using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    internal class PlasmaTV : ITVImplementor
    {
        public void TurnOn()
        {
            Console.WriteLine("Plasma TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Plasma TV is OFF");
        }
    }
}
