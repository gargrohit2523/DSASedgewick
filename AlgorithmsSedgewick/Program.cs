using AlgorithmsSedgewick.LinkedList;
using AlgorithmsSedgewick.Queue;
using System;

namespace AlgorithmsSedgewick
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueDriver();
            Console.ReadLine();
        }

        public static void QueueDriver()
        {
            RingBuffer<int> buffer = new RingBuffer<int>(10);
            buffer.Enqueue(1);
            buffer.Enqueue(2);

            Console.WriteLine(buffer.Dequeue());
            Console.WriteLine(buffer.Dequeue());

            Console.WriteLine(buffer.count);
        }

        public static void DriverDoublyLinkedList()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Console.WriteLine(list.InsertBeginning(2));
            Console.WriteLine(list.InsertBeginning(1));
            Console.WriteLine(list.InsertEnd(3));

            list.GetAllItems();
        }

        public static void DriverSinglyLinkedList()
        {
            SinglyLinkedList<int> list = new SinglyLinkedList<int>();

            for (int i = 1; i <= 1000; i++)
            {
                list.InsertFirst(i);
            }

            list.Reverse();

            //list.GetAllItems();
        }

        public static void DriverForBalancedArithmeticExpression() {
            var inputExpression = "1 + 2 ) * 3 - 4 ) * 5 - 6 ) ) )";
            try
            {
                var output = BalanceArithmeticExpression.BalanceForLeftParenthesis(inputExpression);
                Console.WriteLine(output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
