using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            Task<int> t = Task.Run(()=>
            {
                for (int j = 0; j < 1000; j++) Console.Write(".");
                return 42;
            });

            //These two lines were added for testing pupose
            //t.Wait();
            //Console.WriteLine("Done");


            Console.WriteLine(t.Result); //seems like t.Result implicitly calls t.wait 
        }
    }
}
