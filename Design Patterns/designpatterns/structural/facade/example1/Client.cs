using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.facade
{
    internal class Client
    {
        public static void MainMethod()
        {
            Facade facade=new Facade();

            facade.Operation1();
            facade.Operation2();
        }
    }
}
