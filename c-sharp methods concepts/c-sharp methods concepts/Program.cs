using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.METHODS 2.PARAMETERS 3.OVERLODING

/*namespace c_sharp_methods
{
    class Program
    {
        static void mymethod()
            {
            Console.WriteLine("hi!");
            }
        static void Main(string[] args)
        {
            mymethod();
            Console.Read();
        }
    }
}
*/

/*namespace c_sharp_methods
{
    class Program
    {
        static void mymethod(int x,int y)
        {
            Console.WriteLine(x+y + " is the sum");
        }
        static void Main(string[] args)
        {
            mymethod(3,4);
            Console.Read();
        }
       
    }
}*/


/*namespace c_sharp_methods
{
    class Program
    {
        static int mymethod(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mymethod(4, 5) + " is the sum");
            Console.Read();
        }

    }
}

*/


/*namespace c_sharp_methods
{
    class Program
    {
       static void mymethod(string fname)
        {
            Console.WriteLine(fname + " refenes");
        }
        static void Main(string[] args)
        {
            mymethod("gubbi");
                mymethod("navven");
            Console.Read();
        }
     }

}
*/

/*namespace c_sharp_methods
{
    class Program
    {
        static void mymethod(string fname="chotu")
        {
            Console.WriteLine(fname + " refenes");
        }
        static void Main(string[] args)
        {
            mymethod("gubbi");
            mymethod("navven");
            mymethod();
            Console.Read();
        }
    }

}
*/

/*namespace c_sharp_methods
{
    class Program
    {
        static void mymethod(string c1, string c2, string c3)
        {
            Console.WriteLine("the name of c1 is:"  + c1);
        }
        static void Main(string[] args)
        {
            mymethod(c1:"gubbi",c2:"naveen",c3:"chotu");

            Console.Read();
        }
    }

}*/

/*namespace c_sharp_methods
{
    class Program
    {
        static void Mymethod(string c2="gubbi", string c1="naveen", string c3="chootu")
        {
            Console.WriteLine(c1);
        }
        static void Main(string[] args)
        {
            Mymethod("c1");

            Console.Read();
        }
    }

}
*/

/*namespace c_sharp_methods
{
    class Program
    {
        static int mymethod(int x, int y)
        {
            return x + y;
        }
        static double mymethod1(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int frstnum = mymethod(4, 5);
            double lstnum = mymethod1(4.3, 5.4);
            Console.WriteLine("int:" + frstnum);
            Console.WriteLine("double:" + lstnum);
            Console.ReadLine();
        }
    }
}*/

namespace c_sharp_methods
{
    class Program
    {
        static int mymethod(int x, int y)
        {
            return x + y;
        }
        static double mymethod(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int frstnum = mymethod(4, 5);
            double lstnum = mymethod(4.3, 5.4);
            Console.WriteLine("int:" + frstnum);
            Console.WriteLine("double:" + lstnum);
            Console.ReadLine();
        }
    }
}
