using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    // Concrete Implementors
    internal class LEDTV : ITVImplementor
    {
        public void TurnOn()
        {
            Console.WriteLine("LED TV is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("LED TV is OFF");
        }
    }
}
