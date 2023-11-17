using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.bridge
{
    // Abstraction
    internal abstract class TV
    {
        protected ITVImplementor implementor;

        protected TV(ITVImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }
}
