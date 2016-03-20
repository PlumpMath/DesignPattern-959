using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************/
/* Author:LiChao
/* Date:2016/03/04
/* Description:FactoryMethod Pattern
/* Target:实现一个工厂方法模式                                         
/**************************************************************/

namespace FactoryMethod
{
    abstract class AbstractCar
    {
        public abstract void Startup();

        public abstract void Run();

        public abstract void Turn(Direction direction);

        public abstract void Stop();

    }

    public enum Direction
    {
        Left,
        Right
    }
}
