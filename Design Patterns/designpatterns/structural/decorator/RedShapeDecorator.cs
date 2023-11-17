using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.decorator
{
    // concret decorator class
    internal class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(IShape decoratedShape)  : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}
