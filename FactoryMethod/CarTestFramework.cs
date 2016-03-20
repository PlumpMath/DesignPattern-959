using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class CarTestFramework
    {
        //public void BuildTestContext(AbstractCar car)
        //{
        //    //Car car = new Car();
        //    //...

        //    car.Startup();

        //    //如果要有n个car
        //    AbstractCar car1 =
        //}

        public void BuildTestContext(CarFactory carFactory)
        {
            AbstractCar c1 = carFactory.CreateCar();

            //AbstractCar c2 = carFactory.CreateCar();
        }

        public void DoTest(AbstractCar car)
        {
            //Car car = new Car();
            car.Run();
        }

        public TestData GetTestData()
        {

        }
    }
}
