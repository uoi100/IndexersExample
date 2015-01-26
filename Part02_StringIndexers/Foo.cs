using System;
using System.Collections;

namespace Part02_StringIndexers
{
    class Foo
    {
        private ArrayList pairs;
        private bool error;

        /// <summary>
        /// Description: Constructor that allocates the size of the name and value.
        /// </summary>
        /// <param name="size"></param>
        public Foo()
        {
            pairs = new ArrayList();
            error = false;
        }

        /// <summary>
        /// Description: String Indexer this gets the value of the pair based on its string ( The key ),
        /// it also sets and automatically adds a string to the arraylist if it doesn't exist.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public object this[string key]
        {
            get
            {
                for (int i = 0; i < pairs.Count; i++)
                {
                    Pair pair = (Pair) pairs[i];
                    if (pair.Key == key)
                    {
                        error = false;
                        return pair.Data;
                    }
                }
                error = true;
                return "Invalid Key";
            }
            set
            {
                error = false;
                for( int i = 0; i < pairs.Count; i++)
                {
                    Pair pair = (Pair) pairs[i];
                    if(pair.Key == key)
                    {
                        pair.Data = value;
                        pairs[i] = pair;
                    }
                }
                Pair newPair = new Pair( key, value );
                pairs.Add(newPair);
            }
        }
  
        /// <summary>
        /// Description: Integer indexer, this is used to return the value at the index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                if( index >= 0 && index < pairs.Count)
                {
                    error = false;
                    Pair pair = (Pair) pairs[index];
                    return pair.Data;
                }
                error = true;
                return "Index out of bounds.";
            }
        }

        /// <summary>
        /// Description: Print the pair key and data.
        /// </summary>
        /// <param name="index"></param>
        /// <returns>Returns a string of the key and data.</returns>
        public string get(int index)
        {
            if (index >= 0 && index < pairs.Count)
            {
                error = false;
                Pair pair = (Pair)pairs[index];
                return pair.Key.ToString() + ": " + pair.Data.ToString();
            }
            error = true;
            return "Index out of bounds.";
        }

        /// <summary>
        /// Description: Returns the number of elements the pairs array holds.
        /// </summary>
        public int Length
        {
            get
            {
                return pairs.Count;
            }
        }

        /// <summary>
        /// Description: Check if there is an error or not
        /// </summary>
        /// <param name="?"></param>
        /// <returns>Returns true if there is an error, else false.</returns>
        public bool isGood(){ return !error; }
    }
}
