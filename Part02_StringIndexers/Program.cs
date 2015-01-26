using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02_StringIndexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();
            foo["Q"] = 123;
            foo["W"] = 321.123122;
            foo["O"] = "Hello World!";
            foo["P"] = 123.11m;

            for (int i = 0; i <= foo.Length; i++)
                Console.WriteLine(foo.get(i));

            Console.WriteLine("");

            Console.WriteLine(foo["W"]);
            Console.WriteLine(foo["O"]);
            Console.WriteLine(foo["P"]);
            Console.WriteLine(foo["Z"]);

            Console.Read();
        }
    }
}
