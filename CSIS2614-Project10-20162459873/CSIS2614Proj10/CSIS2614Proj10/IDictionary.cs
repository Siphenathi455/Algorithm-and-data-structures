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
    interface IDictionary<K, V> where K : IComparable
    {
        void Add(K key, V value);
        bool ContainsKey(K key);
        void Clear();
        void Remove(K key);
    }
}
