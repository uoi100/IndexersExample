using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part01_IntegerIndexers
{
    class Foo
    {
        private int[] bar;
        private bool error;

        /// <summary>
        /// Description: Constructor, bar is allocated some space
        /// </summary>
        public Foo()
        {
            bar = new int[10];
        }

        /// <summary>
        /// Description: Constructor, bar is allocated to the size
        /// </summary>
        /// <param name="size">Size of the array</param>
        public Foo(int size)
        {
            bar = new int[size];
        }

        /// <summary>
        /// Description: Integer indexer
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int this[int number]
        {
            get
            {
                if (validateBounds(number))
                    return bar[number];
                return 0;
            }
            set
            {
                if (validateBounds(number))
                    bar[number] = value;
            }
        }

        /// <summary>
        /// Description: Validate if the number is within bounds,
        /// if it is then return true, else return false.
        /// The error variable is also set to determine the result of the
        /// the validation.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool validateBounds(int number)
        {
            if (number >= 0 && number < bar.Length)
            {
                error = false;
                return true;
            }

            error = true;
            return false;
        }

        /// <summary>
        /// Description: Returns if the current
        /// </summary>
        /// <returns>Returns if there is an error or not</returns>
        public bool isGood(){ return !error; }
    }
}
