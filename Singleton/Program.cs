﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton t1 = Singleton.Instance;
            Singleton t2 = Singleton.Instance;

            Console.WriteLine(object.ReferenceEquals(t1,t2));
            Console.ReadKey();
        }
    }
}
