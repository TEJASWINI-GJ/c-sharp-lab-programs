using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_class_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;

            int v1 = 20, v2 = 40;
            Console.WriteLine(Math.Max(v1, v2));
            Console.WriteLine(Math.Min(v1, v2));
            int temp = Math.DivRem(v1, v2, out res);
            Console.WriteLine(temp + " " + res);
            Console.ReadLine();


        }
    }
}
