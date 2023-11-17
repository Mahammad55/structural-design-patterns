using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.facade.example2
{
    internal class FacadePatternDemo
    {
        public static void MainMethod()
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawSquare();
            shapeMaker.DrawRectangle();
        }
    }
}
