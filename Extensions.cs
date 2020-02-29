using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Double_Linked_List
{
    public static class Extensions
    {
        public static void PrintEnumerable<T>( IEnumerable<T> item)
        {
            Console.WriteLine(String.Join("->", item));
        }

        public static void PrintEnumerableBackwards<T>(this IEnumerable<T> item)
        {
            Console.WriteLine(String.Join("->", item.Reverse()));
        }
    }
}
