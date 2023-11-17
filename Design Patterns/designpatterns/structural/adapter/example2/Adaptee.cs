using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.adapter.example2
{
    internal class Adaptee
    {
        // The adaptee contains some useful behavior but its interface is incompatible with the existing client code.
        // The adaptee needs some adaptation before the client code can use it
        public string getSpecificRequest()
        {
            return "Specific request";
        }
    }
}
