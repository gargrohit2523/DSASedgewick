
using System;

namespace AlgorithmsSedgewick.LinkedList
{
  public class SinglyLinkedList<T> where T : IComparable
  {
    private Node first;

    private int Count { get; set; }

        public void InsertFirst(T item)
        {
          Node node = new Node()
          {
            Item = item
          };
          if (this.first == null)
          {
            this.first = node;
          }
          else
          {
            Node first = this.first;
            this.first = node;
            this.first.Next = first;
          }
          ++this.Count;
        }

        public int GetCount() => this.Count;

        public void RemoveFirst()
        {
          this.first = this.first.Next;
          --this.Count;
        }

        public void GetAllItems()
        {
          for (Node node = this.first; node != null; node = node.Next)
            Console.WriteLine((object) node.Item);
        }

        public void RemoveLast()
        {
          if (this.Count == 0)
            return;
          if (this.Count == 1)
            this.first = null;

          Node current = this.first;
          Node node2 = new Node();
          while(current != null)
          {
            if (current.Next.Next == null)
            {
              node2 = current;
              break;
            }
          }
          node2.Next = null;
          --this.Count;
        }

        public void Remove(int index)
        {
          if (this.Count == 0)
            return;
          Node current = this.first;
          for (int index1 = 0; index1 < this.Count; ++index1)
          {
            if (index1 == index - 1)
            {
              Node node2 = current;
              Node next = current.Next.Next;
              node2.Next = null;
              node2.Next = next;
              break;
            }
            current = current.Next;
          }
          --this.Count;
        }

       public T Max()
       {
            Node current = this.first;
            T max = current.Item;
            for (int index1 = 0; index1 < this.Count; ++index1)
            {
                if (current.Next == null)
                    break;
                if (current.Next.Item.CompareTo(max) > 0)
                    max = current.Next.Item;
                
                current = current.Next;
            }
            return max;
        }

        public void Reverse()
        {
            Node current = this.first;
            Node reverse = null;

            while(current != null)
            {
                Node temp = current.Next;
                current.Next = reverse;
                reverse = current;
                current = temp;
            }

            this.first =  reverse;
        }

    private class Node
    {
      public T Item { get; set; }

      public Node Next { get; set; }
    }
  }
}
