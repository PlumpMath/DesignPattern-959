using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Adapter
{

    interface IStack//客户期望的适配接口
    {
        void Push(object item);
        object Pop();

        //取顶层对象但是不pop
        object Peek();
    }

    //对象适配器
    class Adapter:IStack//适配对象
    {
        ArrayList adatee;//被适配的对象
        public Adapter()
        {
            adatee = new ArrayList();
        }

        public object Peek()
        {
            object obj = adatee[adatee.Count - 1];
            return obj;
        }

        public object Pop()
        {
            object obj = adatee[adatee.Count-1];
            adatee.RemoveAt(adatee.Count-1);
            return obj;
        }

        public void Push(object item)
        {
            adatee.Add(item);
        }
    }

    //类适配器(一般不用，一般用对象适配器)
    class Adapter1 :ArrayList, IStack//适配对象
    {
        public object Peek()
        {
            object obj = this[this.Count - 1];
            return obj;
        }

        public object Pop()
        {
            object obj = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
            return obj;
        }

        public void Push(object item)
        {
            this.Add(item);
        }
    }
}
