using SOLIDConsole.SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLIDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton test = Singleton.Instance;
            test.DoSometing();
            Singleton.SayHi();

            Console.ReadKey();
        }

    }
}
