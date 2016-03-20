using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**************************************************************/
/* Author:LiChao
/* Date:2016/02/29
/* Description:Singleton Pattern
/* Target:实现一个单例模式                                           
/**************************************************************/

namespace Singleton
{
    class Singleton
    {

        #region 不考虑多线程的情况
        //private static Singleton instance;

        //private Singleton() { }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new Singleton();
        //        }
        //        return instance;
        //    }
        //}
        #endregion

        #region 考虑多线程
        //private static volatile Singleton instance = null;//volatile

        //private static object lockHelper = new object();

        //private Singleton() { }

        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (lockHelper)
        //            {
        //                if (instance == null)//double check
        //                {
        //                    instance = new Singleton();
        //                }
        //            }
        //        }
        //        return instance;
        //    }
        //}
        #endregion

        #region 考虑多线程的最简单写法
        public static readonly Singleton Instance = new Singleton();//内联初始化

        private Singleton() { }
        #endregion

    }
}
