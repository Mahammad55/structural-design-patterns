using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual_Work_C_.designpatterns.structural.adapter
{
    internal class MobileAdapterImpl : IMobileAdapter
    {
        private readonly IWallSocket wallSocket;

        public MobileAdapterImpl(IWallSocket wallSocket)
        {
            this.wallSocket = wallSocket;
        }

        public Volt Get3Volts()
        {
            Volt v240 = wallSocket.GetVolts();
            int v3 = v240.GetVolts() / 80;
            return new Volt(v3);
        }
    }
}
