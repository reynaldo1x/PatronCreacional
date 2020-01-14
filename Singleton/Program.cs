using Singleton.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The client code.
            MySingleton s1 = MySingleton.GetInstance();
            MySingleton s2 = MySingleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadLine();
        }
    }
}
