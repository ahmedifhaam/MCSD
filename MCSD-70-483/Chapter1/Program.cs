using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {

        public static void ThreadMethod()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Proc {0}", i);
                Thread.Sleep(0);
            }

        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread : Do somework!!");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}
