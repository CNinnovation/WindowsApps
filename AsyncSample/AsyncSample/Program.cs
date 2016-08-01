using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            Program p = new Program();
            p.CallGreeting().Wait();
        }

        public async Task CallGreeting()
        {
            Console.WriteLine($"{nameof(CallGreeting)} started");
            //string result = Greeting(1000, "Stephanie");
            //Console.WriteLine(result);

            Task<string> t1 = GreetingAsync(1000, "Stephanie");
            Task<string> t2 = GreetingAsync(600, "Matthias");
            await Task.WhenAll(t1, t2);
            Console.WriteLine(t1.Result);
            Console.WriteLine(t2.Result);
            Console.WriteLine($"{nameof(CallGreeting)} ended");
        }

        public Task<string> GreetingAsync(int ms, string name)
        {
            return Task.Run<string>(() =>
            {
                return Greeting(ms, name);
            });
        }

        public string Greeting(int ms, string name)
        {
            Thread.Sleep(ms);
            return $"Hello, {name}";
        }
    }
}
