using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part03_NonArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();

            for (int i = 0; i <= 10; i++)
                Console.WriteLine(foo[i]);

            Console.Read();
        }
    }
}
