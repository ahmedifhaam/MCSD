using System;
using System.Threading;

namespace Chapter1
{
    public static class Program
    {


        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void Main()
        {

            new Thread(() =>
            {
                for(int x = 0; x < 10; x++)
                {
                    
                    Console.WriteLine("Thread A: {0} ", _field.Value);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    
                    Console.WriteLine("Thread B: {0}", _field.Value);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
