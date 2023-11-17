using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.facade.example2
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle::Draw()");
        }
    }
}
