using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01_IntegerIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();

            foo[0] = 21;

            foo[51] = 11;

            // This will not throw an exception because of the indexer's fail-soft array
            Console.WriteLine(foo[0]);
            Console.WriteLine(foo[51]);
            Console.WriteLine(foo[53]);
            Console.Read();
        }
    }
}
