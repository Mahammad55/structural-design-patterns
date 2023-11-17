using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    internal class SamsungTV : TV
    {
        public SamsungTV(ITVImplementor implementor) : base(implementor)
        {
        }

        public override void TurnOn()
        {
            Console.Write("Samsung TV - ");
            implementor.TurnOn();
        }

        public override void TurnOff()
        {
            Console.Write("Samsung TV - ");
            implementor.TurnOff();
        }
    }
}
