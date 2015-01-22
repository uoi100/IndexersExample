using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part02_StringIndexers
{

    /// <summary>
    /// Description: Container class that holds the key of the object and the data.
    /// </summary>
    class Pair
    {
        private string key;
        private object data;

        public Pair(string key, object data)
        {
            this.key = key;
            this.data = data;
        }

        public string Key
        {
            get { return key; }
            set { key = value; }
        }

        public object Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
