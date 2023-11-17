using System;

namespace Design_Patterns.designpatterns.structural.bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITVImplementor ledImplementor = new LEDTV();
            ITVImplementor plasmaImplementor = new PlasmaTV();

            TV sonyLED = new SonyTV(ledImplementor);
            TV samsungPlasma = new SamsungTV(plasmaImplementor);

            sonyLED.TurnOn();
            sonyLED.TurnOff();

            Console.WriteLine();

            samsungPlasma.TurnOn();
            samsungPlasma.TurnOff();
        }
    }
}
