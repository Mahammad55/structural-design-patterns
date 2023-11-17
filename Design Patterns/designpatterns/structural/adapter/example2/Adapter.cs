using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.adapter.example2
{
    internal class Adapter : ITarget
    {
        // The adapter makes the adaptee's interface compatible with the target interface
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string getRequest()
        {
            return $"This is '{this._adaptee.getSpecificRequest()}'";
        }
    }
}
