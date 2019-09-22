using System;
using System.Threading;

namespace Chapter1
{
    public static class Program4
	{
		public static void ThreadMethod(Object o){
            for (int i =0;i<(int)o;i++){
                Console.WriteLine("Thread Proc {0}",i);
                Thread.Sleep(0);
            }
        }

        public static void Main(String[] args)
        {
            bool stoped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stoped)
                {
                    Console.WriteLine("Runnning ...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press Any key to stop..");
            Console.ReadKey();
            stoped = true;
            t.Join();
        }
    }
}
