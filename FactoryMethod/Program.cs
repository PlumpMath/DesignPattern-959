using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTestFramework carTestFramework = new CarTestFramework();
            carTestFramework.BuildTestContext(new HongQiCarFacory());
        }
    }
}
