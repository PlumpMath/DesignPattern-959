using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ExistingClass
    {
        public void SpecificRequest1()
        {

        }

        public void SpecificRequest2()
        {

        }
    }

    //新环境所使用的接口
    interface ITarget
    {
        void Request();
    }

    //另外一个系统
    class MySystem
    {
        public void Process(ITarget target)
        {

        }
    }

    class Adapter2 : ITarget
    {
        ExistingClass adaptee;
        public void Request()
        {
            adaptee.SpecificRequest1();
            adaptee.SpecificRequest2();
        }
    }
}
