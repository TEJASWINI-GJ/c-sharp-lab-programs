using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple calc");
            Console.WriteLine("enter the numbers");
            int var1, var2;
            var1 = Convert.ToInt32(Console.ReadLine());
            var2 = Convert.ToInt32(Console.ReadLine());

            int addres, subres, mulres, divres;


            addres = var1 + var2;
            subres = var1 - var2;
            mulres = var1 * var2;
            divres = var1 / var2;

            Console.WriteLine("results");
            A.WriteLine("add=" + addres + "\n" + "sub=" + subres + "\n" + "mul=" + mulres + "\n" + "div=" + divres + "\n");
            A.ReadLine();
        }
    }
}

