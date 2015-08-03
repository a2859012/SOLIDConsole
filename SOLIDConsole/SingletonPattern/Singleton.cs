using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOLIDConsole.SingletonPattern
{
    public class Singleton
    {
        private static readonly Lazy<Singleton> LazyInstance = new Lazy<Singleton>(() => new Singleton());

        private Singleton() { }

        public static Singleton Instance { get { return LazyInstance.Value; } }

        public static void SayHi()
        {
            Console.WriteLine("Hi All ~~");
        }

        public void DoSometing()
        {
            Console.WriteLine("Do Someting ....");
        }
    }
}
