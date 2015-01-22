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
            foo["A"] = 123;
            foo["B"] = 321.123122;
            foo["W"] = "Hello World!";
            foo["Z"] = 123.11m;

            for (int i = 0; i <= foo.Length; i++)
                Console.WriteLine(foo.get(i));
            

            Console.Read();
        }
    }
}
