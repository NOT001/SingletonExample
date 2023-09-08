using System;

namespace SingletonExample
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.DoSomething();
        }
    }
}
