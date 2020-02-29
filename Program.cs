using System;

namespace Double_Linked_List
{
    class Program
    {
        static void Main()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.PrintForwards();
            list.AddFirst(0);
            list.PrintForwards();
            Console.WriteLine(list.RemoveFirst());
            list.PrintForwards();
            list.RemoveLast();
            list.PrintForwards();
            list.AddLast(3);
            Console.WriteLine( list.Remove(2));
            list.PrintForwards();
            list.PrintBackwards();

            //Extensions.PrintEnumerable(list);
            list.PrintEnumerable();
            list.PrintEnumerableBackwards();

            //Extensions.PrintEnumerableBackwards(list);


            //////////////////////////
            //Next Week:
            //Circular Linked List
            //Recursion
            //Unique Ptrs
        }
    }
}
