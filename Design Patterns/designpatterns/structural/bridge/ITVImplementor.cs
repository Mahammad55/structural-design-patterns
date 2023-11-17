using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    // Implementor interface
    internal interface ITVImplementor
    {
        void TurnOn();
        void TurnOff();
    }
}
