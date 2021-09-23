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
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {

        private class Node
        {
            internal T Item { get; set; }
            internal Node Next { get; set; }
            internal Node previous { get; set; }
 
            internal Node(T _Item, Node _prevNode, Node _Next)
            {
                    this.Item = _Item;
                    Next = _Next;
                    previous = _prevNode;
                if (previous != null) 
                    previous.Next = this;

                    this.Next = _Next;
            }
        } //class Node
        private int iCount;
        private Node head;
        public DoubleLinkedList()
        {
            this.iCount = 0;

        }
        public T this[int i]
        {
            get
            {
                if (i < 0 || i >= iCount)
                    return default(T);
                Node current = head;
                for (int j = 0; j < i; j++)
                    current = current.Next;
                return current != null ? current.Item : default(T);
            }
        }

        public int Count{ get { return this.iCount;  }  }

        public void Add(T item)
        {
            if (this.head == null)
                head = new Node(item, null, null);
            else
            {
                Node current = this.head;
                Node prev = null;
                while (current != null)
                {
                    prev = current;
                    current = current.Next;
                }
                current = new Node(item, prev, null);
            }
            iCount++;
        }

        public void Clear()
        {
           this.head = null;
            iCount = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
                yield return this[i];
                

        }

        public void Insert(int index, T item)
        {
            if (index < 0 || index > Count)
            {
                Console.WriteLine("\tIndex must be within the bounds of the list.\n\tParameter name: Index.");
                Console.Write("\n\tPress any key to exit ...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                if (index == 0)
                {
                    if (this.head == null)
                        head = new Node(item, null, null);
                    else
                    {
                        Node Next = this.head;
                        Node prev = null;
                        head = new Node(item, prev, Next);
                    }
                    iCount++;
                }
                else
                {

                    Node current = head;
                    Node prev = null;
                    for (int i = 0; i < index; i++)
                    {
                        prev = current;
                        current = current.Next;

                    }

                    Node newNode = new Node(item, prev, current);
                    iCount++;
                }
            }
        }
 
        public void Remove(T item)
        {
            Node Current = this.head;
            Node Prev = null;
            int i = 0;
            bool isremoved = false;
            while ( i < Count && !isremoved)
            {
                if (Object.Equals(Current.Item, item))
                {
                    if (Prev == null)
                        this.head = Current.Next;
                    else
                       Prev.Next = Current.Next;

                    iCount--;
                    isremoved = true;
                }
                else
                {
                    Prev = Current;
                    Current = Current.Next;
                }
                i++;
            }
        }


    }
}
// with recognition to
//https://youtu.be/OXSapArd-E8
//https://stackoverflow.com/questions/5682408/command-to-close-an-application-of-console
//CSIS2614 LinkedList class example
