using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsSedgewick.Queue
{
    public class RingBuffer<T>
    {
        T[] data;
        public int capacity { get; private set;}
        public int count { get; private set; }

        public RingBuffer(int capacity)
        {
            this.capacity = capacity;
            this.data = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (this.count < this.capacity)
            {
                data[count] = item;
                count++;
            }
        }

        public T Dequeue()
        {

            if (this.count == 1)
            {
                var temp = this.data[0];
                data = new T[capacity];
                count--;
                return temp;
            }

            var frontElement = data[0];

            for(int i=0; i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }

            count--;
            return frontElement;

        }
    }
}
