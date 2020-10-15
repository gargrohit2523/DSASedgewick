using AlgorithmsSedgewick.LinkedList;
using System;

namespace AlgorithmsSedgewick
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverSinglyLinkedList();
            Console.ReadLine();
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
            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(3);
            list.InsertFirst(4);

            list.Reverse();

            list.GetAllItems();
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
