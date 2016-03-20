using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class HongQiCarFacory:CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new HongQiCar();
        }
    }
}
