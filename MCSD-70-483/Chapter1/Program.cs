using System;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            Task t = Task.Run(()=>
            {
                for(int x = 0; x < 10; x++)
                {
                    Console.WriteLine("*");
                }
            });
            

            
            t.Wait(); 
        }
    }
}
