using System;
using System.Threading;
using System.Net.Http;
using System.Threading.Tasks;

namespace Chapter1
{
    public static class Program
    {

        public static void Main()
        {
            string result = DownloadContent().Result;
            Console.Write(result);

        }

        public static async Task<String> DownloadContent()
        {
            using(HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("Http://www.microsoft.com");
                return result;
            }
        }
    }
}
