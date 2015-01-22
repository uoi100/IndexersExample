using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part03_NonArrayExample
{
    class Foo
    {
        /// <summary>
        /// Description: Integer indexer that returns the value squared.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int this[int value]
        {
            get
            {
                return value * value;
            }
        }
    }
}
