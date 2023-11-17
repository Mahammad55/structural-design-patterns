using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.proxy
{
    internal class Program
    {
        static void Main()
        {
            Internet internet = new ProxyInternet();
            internet.ConnectTo("google.com");
            internet.ConnectTo("banned.com");
        }
    }
}
