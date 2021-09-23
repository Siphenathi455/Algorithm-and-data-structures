//2016245983
//Nxele Siphenathi
//CSIS2614 Project 10
//Due date: 06 May 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIS2614Proj10
{
    class MyDictionary<K,V>  : IDictionary<K,V> where K : IComparable
    {
        SortedDictionary<K, V> Dictionary;
       public MyDictionary()
        {
            Dictionary = new SortedDictionary<K, V>();
        }
        public V this[K key]
        {
            get {
                 V value;

                 Dictionary.TryGetValue(key, out value);

                    return value; 
                }
        }


        public void Add(K key, V value)
        {
            Dictionary.Add(key, value);
        }

        public void Clear()
        {
            Dictionary.Clear();
        }

        public bool ContainsKey(K key)
        {
           return Dictionary.ContainsKey(key);
        }

        public void Remove(K key)
        {
            Dictionary.Remove(key);
        }
    }
}
