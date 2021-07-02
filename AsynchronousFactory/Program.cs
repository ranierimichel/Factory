using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousFactory
{
    public class Foo
    {
        private Foo()
        {

        }

        private async Task<Foo> InitAsync()
        {
            Console.WriteLine("Initializing");
            await Task.Delay(3000);
            return this;
        }

        public static Task<Foo> CreateAsync()
        {            
            var result = new Foo();
            return result.InitAsync();
        }

        public override string ToString()
        {
            return $"Foo";
        }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            Foo x = await Foo.CreateAsync();
            Console.WriteLine(x);
        }
    }
}
