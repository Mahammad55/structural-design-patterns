using System;

namespace Individual_Work_C_.designpatterns.structural.adapter
{
    internal class MainClass
    {
        public static void Print()
        {
            // Get voltage from the wall socket
            IWallSocket wallSocket = new WallSocketImpl();
            Volt v240 = wallSocket.GetVolts();
            Console.WriteLine(v240);

            Console.WriteLine("-----------------------");

            // Get voltage through the mobile adapter (Using Adapter)
            IMobileAdapter mobileAdapter = new MobileAdapterImpl(wallSocket);
            Volt v3 = mobileAdapter.Get3Volts();
            Console.WriteLine(v3);
        }
    }
}
