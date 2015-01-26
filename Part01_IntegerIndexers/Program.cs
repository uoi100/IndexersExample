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
            Foo foo = new Foo(10); // Declare foo with a size of 10
             
            // From 0 to 10 inclusively, assign foo[index] to index.
            // Notice that '<=' does not crash the program.
            // This is thanks to the Fail-Soft Array that was setup.
            for (int i = 0; i <= 10; i++)
                foo[i] = i;

            // From 0 to 30 inclusively, print the values in foo[index].
            for (int i = 0; i <= 30; i++)
                Console.Write(foo[i] + " ");

            Console.Read();
        }
    }
}
