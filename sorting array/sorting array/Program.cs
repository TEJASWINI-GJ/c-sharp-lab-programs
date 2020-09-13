using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 98, 23, 97, 36, 77, 56, 89, 10, 87, 96 };
            Console.WriteLine("Unsorted array");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Array.Sort(list);
            Console.WriteLine("\nSorted List");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
