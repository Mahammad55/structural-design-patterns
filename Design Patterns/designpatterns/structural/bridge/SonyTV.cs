using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    // Refined Abstraction
    internal class SonyTV : TV
    {
        public SonyTV(ITVImplementor implementor)
        : base(implementor)
        {
        }

        public override void TurnOn()
        {
            Console.Write("Sony TV - ");
            implementor.TurnOn();
        }

        public override void TurnOff()
        {
            Console.Write("Sony TV - ");
            implementor.TurnOff();
        }
    }
}
