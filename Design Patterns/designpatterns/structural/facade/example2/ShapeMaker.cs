using Individual_Work_C_.designpatterns.structural.facade.example2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.facade.example2
{
    internal class ShapeMaker
    {
        private IShape square;
        private IShape circle;
        private IShape rectangle;

        public ShapeMaker()
        {
            this.square = new Square();
            this.circle = new Circle();
            this.rectangle = new Rectangle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }

        public void DrawSquare()
        {
            square.Draw();
        }
    }
}
