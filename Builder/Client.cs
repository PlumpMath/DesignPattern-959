using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Client
    {
        public static void Main()
        {
            string assemblyName = ConfigurationSettings.AppSettings["BuilderAssebmly"];
            string builderName = ConfigurationSettings.AppSettings["BuilderClass"];

            Assembly assembly = Assembly.Load(assemblyName);

            Type t = assembly.GetType("builderName");

            Builder builder = (Builder)Activator.CreateInstance(t);

            House house = GameManager.CreateHouse(builder);
        }
    }
}
