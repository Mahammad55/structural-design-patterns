
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.decorator
{
    internal class Program
    {
        public static void MainMethod()
        {
            // Creating a simple circle and square
            IShape circle=new Circle();
            IShape square= new Square();

            // Creating a decorated circle and square with a red border
            IShape redCircle=new RedShapeDecorator(new Circle());
            IShape redSquare = new RedShapeDecorator(new Square());

            // simples
            circle.Draw();
            square.Draw();

            // decorates
            redCircle.Draw();
            redSquare.Draw();
        }
    }
}
