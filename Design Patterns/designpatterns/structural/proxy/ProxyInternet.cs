using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.designpatterns.structural.proxy
{
    internal class ProxyInternet : Internet
    {
        private static readonly List<string> BannedSites;
        private readonly Internet _internet = new RealInternet();

        static ProxyInternet()
        {
            BannedSites = new List<string>
        {
            "banned.com",
            "abc.com",
            "lnm.com"
        };
        }

        public void ConnectTo(string host)
        {
            if (BannedSites.Contains(host.ToLower()))
            {
                Console.WriteLine("Access Denied!!");
                return;
            }

            _internet.ConnectTo(host);
        }
    }
}
