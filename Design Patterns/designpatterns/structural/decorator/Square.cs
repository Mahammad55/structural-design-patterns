using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.decorator
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }
}
