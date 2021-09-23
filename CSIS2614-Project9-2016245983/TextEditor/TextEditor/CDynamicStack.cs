//2016245983
//Nxele Siphenathi
//CSIS2614 project 9
//Due date:15 April 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextEditor
{
    class CDynamicStack<T>
    {
        private class Node
        {
            public T Item { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T _Item, Node _Prev)
            {
                Item = _Item;
                Next = null;
                if (_Prev != null)
                    Previous = _Prev;
            }
        }

        private Node head, tail;
        int n = 1;
        private int Capacity;
        private int count;
        public int Count
        {
            get { return this.count; }
        }
 
        public CDynamicStack(int _Capacity)
        {
            Capacity = _Capacity;
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public void Push(T item)
        {
            if (n != Capacity)
            {
                if (this.head == null)
                    this.head = this.tail = new Node(item, null);
                else
                {
                    tail = new Node(item, tail);
                }
                count++;
            }
        }

        public T Pop()
        {
            if (count > 0)
            {
                T item = head.Item;
                head = head.Next;
                count--;
                return item;
            }
            return default(T);
        }
        public T Peek()
        {
            return tail.Item;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        } 

    }
}
