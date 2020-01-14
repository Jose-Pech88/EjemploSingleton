using System;
using Singleton.Services;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            SingletonExample s1 = SingletonExample.GetInstance();
            SingletonExample s2 = SingletonExample.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }
            Console.ReadKey();
        }
    }
}
