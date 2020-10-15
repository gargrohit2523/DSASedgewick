using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSedgewick.LinkedList
{
    public class DoublyLinkedList<T>
    {
        Node First { get; set; }
        public int Count { get; private set; }
        private class Node
        {
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public T Item { get; set; }
        }

        public int InsertBeginning(T item)
        {
            if (this.Count == 0)
            {
                this.First = new Node() { Item = item };
            }
            else {
                var first = this.First;
                Node newNode = new Node() { Item = item };
                newNode.Next = first;
                first.Prev = newNode;
                this.First = newNode;
            }

            return ++this.Count;
        }

        public int InsertEnd(T item)
        {
            if (this.Count == 0)
            {
                this.First = new Node() { Item = item };
            }
            else
            {
                var current = this.First;
                while(current != null)
                {
                    if(current.Next == null)
                    {
                        current.Next = new Node() { Item = item };
                        current.Next.Prev = current;
                    }
                    current = current.Next;
                }
            }

            return ++this.Count;
        }

        public void GetAllItems()
        {
            for (Node node = this.First; node != null; node = node.Next)
                Console.WriteLine(node.Item);
        }
    }
}
