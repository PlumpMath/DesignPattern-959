using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            TankPlatformImplementation tabkImp = new MobileTankPlatformImplementation();
            T50 tank = new T50(tabkImp);
        }
    }
}
