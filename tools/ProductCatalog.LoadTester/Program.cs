using ProductCatalog.LoadTester.Generated;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductCatalog.LoadTester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("ERROR: usage ProductCatalog.LoadTester <service_url>");
                Environment.Exit(1);
            }

            var serviceUrl = new Uri(args[0]);
            DoProgram(serviceUrl).Wait();
        }

        private static async Task DoProgram(Uri serviceUrl)
        {
            using (var client = new CatalogServiceAPI(serviceUrl))
            {
                var stopWatch = Stopwatch.StartNew();

                for (int i = 1; i <= 1000000; i++)
                {
                    var products = await client.ApiProductsGetAsync();                    

                    if (i % 1000 == 0)
                    {
                        var millisecondsPerCall = stopWatch.Elapsed.TotalMilliseconds / i;

                        Console.WriteLine($"Done {i} calls in {(int)stopWatch.Elapsed.TotalSeconds} seconds => {millisecondsPerCall} ms/call");
                    }
                }
            }
        }
    }
}
