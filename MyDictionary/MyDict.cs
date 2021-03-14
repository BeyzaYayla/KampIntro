using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T,K>
    {
        T[] keys;
        K[] values;

        public MyDictionary()
        {
            keys = new T[0];
            values = new K[0];
        }

        public void Add(T key, K value)
        {
            T[] tempKeys = keys;
            K[] tempValues = values;
            keys = new T[keys.Length + 1];
            values = new K[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

    }
}
