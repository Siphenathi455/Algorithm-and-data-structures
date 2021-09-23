//2016245983
//Nxele Siphenathi
//CSIS2614 project 8
// Due on 8 April 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    interface IDoubleLinkedList<T>
    {
        int Count { get; }
        IEnumerator<T> GetEnumerator();
        T this[int i] { get; }
        void Clear();
        void Add(T item);
        void Insert(int index, T item);
        void Remove(T item);
    }
}
