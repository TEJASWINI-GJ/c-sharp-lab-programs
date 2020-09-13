using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using A = System.Console;


//CONSOLE

/*
using first;
using second;

namespace first

{
   class test
    {
       public void saytest()
        {
            Console.WriteLine("testing");
            //Console.ReadLine();
        }
    }
    
}

namespace second
{
   class test1

    {
       public void sayprog()
        {
            Console.WriteLine("my program");
            //Console.ReadLine();
        }
    }
}

public class testnamespace
{
    public static void Main(string[] args)
    {
        test t1 = new test();
        test1 p1 = new test1();
        t1.saytest();
        p1.sayprog();
        Console.ReadLine();
    }
}
*/

// VARIABLES


/*namespace variabless
{
    class check
    {
        static void Main(string[] args)
        {
           const int p = 20;
           //p=30;// output will be 30
           Console.WriteLine(p);
           Console.ReadLine();
        }


    }
}*/


//DATA TYPE

/*namespace types
{
    class check
    {
        static void Main(string[] args)
        {
            int mynum = 5;
            double mydoublenum = 2.36D;
            char mychar = 'g';
            bool mybool = true;
            string mytext = "hello";
            float f1 = 35e3F;             // scientic numbers
            Console.WriteLine(mynum);
            Console.WriteLine(mydoublenum);
            Console.WriteLine(mychar);
            Console.WriteLine(mybool);
            Console.WriteLine(mytext);
            Console.WriteLine(f1);
            Console.ReadLine();
        }
    }
}
*/

// TYPE CASTING

/*namespace typecasting
{
    class check
    {
        static void Main(string[] args)
        {
            //implicit casting
              int mynum = 10;
              double mydouble = mynum;
              Console.WriteLine(mynum);
              Console.WriteLine(mydouble);
              Console.ReadLine();

            //explicit casting
             double mydouble = 10.3665;
             int mynum = (Int32)mydouble;
             Console.WriteLine(mydouble);
             Console.WriteLine(mynum);
             Console.ReadLine();

            //METHOD
            int mynum = 8;
            double myd = 10.25;
            bool mybool = true;
            Console.WriteLine(Convert.ToString(mynum));
            Console.WriteLine(Convert.ToDouble(mynum));
            Console.WriteLine(Convert.ToInt32(myd));
            Console.WriteLine(Convert.ToString(mybool));
            Console.ReadLine();
          }
    }
}*/

//USER INPUT

/*namespace userinput
{
    class check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your name:");
            string username = Console.ReadLine();
            Console.WriteLine("my name is:" + username);
            Console.ReadLine();
        }
    }
}*/


// C# MATH

/*namespace mathoperation
{
    class check
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 23;
            int c = -8;
            Console.WriteLine(Math.Max(a, b));
            Console.WriteLine(Math.Min(a, b));
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Abs(c));
            Console.WriteLine(Math.Round(10.89));
            Console.ReadLine();


        }
    }
}*/

//STRINGS

/*namespace strings1
{
    class check
    {
        static void Main(string[] args)
        {
            string txt = "Ashwini";
            string text = " Gowda";
           
            Console.WriteLine("length of the string is:\t" + txt.Length); //length
           
            Console.WriteLine("upper case:\t" + txt.ToUpper());           //upper nd lower case
            Console.WriteLine("lower case:\t" + txt.ToLower());
           
            //string name = string.Concat(txt , text);
            string name = txt + text;                                       //concatination
            Console.WriteLine("after concatination:\t" + name);

            string name1 = $"my full name is :{txt} {text}";
            Console.WriteLine("interpolation:\t" + name1);                    //interpolation(space => automatic)

            Console.WriteLine("charc at index 1 in txt:\t" + txt[1]);
            Console.WriteLine("charc at index 4 in text:\t" + text[4]);               //access char

            Console.WriteLine("index value of A in txt:\t" + txt.IndexOf("A"));
            Console.WriteLine("index value of a in text:\t" + text.IndexOf("a"));         //index pos

            string myname = "Ashwini gowda";
            int charpos = myname.IndexOf("g");
            string lastname = myname.Substring(charpos);
            Console.WriteLine("lastname:\t" + lastname);                                     //substring

            //string special = "practising program in \"c language\".";
            string special = "practising program in \"c#\".";
            Console.WriteLine(special);                                     //special character

            Console.ReadLine();
        }
    }
}*/

//IF ELSE

/*namespace condition
{
    class check
    {
        static void Main(string[] args)
        {
            int time = 18;
             if (time < 12)                                     //comment this normal ifelse to run short hand
             {
                 Console.WriteLine("good morning");
             }
             else
                 Console.WriteLine("good evening");             

            string result = (time < 12) ? "Gm" : "Ge";              //short had if else ternary operator
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}*/

//WHILE LOOP

/*namespace looping
{
    class check
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
*/

//DO WHILE LOOP

/*namespace looping
{
    class check
    {
        static void Main(string[] args)
        {
            int i=0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 6) ;
            Console.ReadLine();
        }
    }
}
*/

//FOR LOOP

/*namespace looping
{
    class check
    {
        static void Main(string[] args)
        {
            //int i;
            //for (i=0;i<5;i++)
            //{
            //  Console.WriteLine(i);
            //}

            string[] cars = { "volvo", "BMW", "ford", "mazda" }; ;
            foreach (string i in cars)                                              //for each loop
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}*/


//BREAK AND CONTINUE

/*namespace brklooping
{
    class check
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}*/

/*namespace contilooping
{
    class check
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}*/

//ARRAYS

/*namespace arraysprob
{
    class check
    {
        static void Main(string[] args)
        {
            string[] weeks = { "sun", "mon", "tue", "wed", "thur","fri","sat" };
            foreach (string i in weeks) 
            {                                                           //print element in an array
                Console.WriteLine(i);
            }

             weeks[0] = "sunday";                          // change the element in an array
              Console.WriteLine(weeks[0]);

            Console.WriteLine(weeks[4]);                        //access the element in an array

           Console.WriteLine("length of the array is :" + weeks.Length);              //length of the array


           for(int i=0;i<weeks.Length;i++)
           {
               Console.WriteLine(weeks[i]);                            //print elements of an array using loop
           }

            Array.Sort(weeks);
            foreach(string sorting in weeks)                           //sorting array
                {
                 Console.WriteLine("sorted array:" + sorting);
                }
          
            Console.ReadLine();
        }
    }
}
*/

//LINQ NAMESPACE

/*namespace arraysub
{
    class check
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 1, 2, 3, 4, 5 };
            foreach(int result in num)
            Console.WriteLine("array elements:" + result);

            Console.WriteLine("max elem:" + num.Max());
            Console.WriteLine("min elem:" + num.Min());
            Console.WriteLine("sum=" + num.Sum());
            
            
            Console.ReadLine();
        }
    }
}*/


//SINGLE DIMENTIONAL USER INPUT

/*namespace single
{
    class check
    {
        static void Main(string[] args)
        {
         
         int[] arr1 = new int[5];
         Console.WriteLine("enter the array values");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());              
            }
            foreach (int t in arr1)
            {
                 Console.WriteLine("array elements:" + t);
            }
        Console.ReadLine();
        }
    }
}*/

//MULTIDIMENTIONAL:

/*namespace multi
{
    class check
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int i, j;

            // output each array element's value 
            for (i = 0; i < 2; i++)
            {

                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("arr1[{0},{1}] = {2}", i, j, arr1[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}*/

//MULTI USER INPUT

namespace userinput
{
    class check
    {
        static void Main(string[] args)
        {
            int[,] A = new int[5, 4];

            //read
            Console.WriteLine("enter the elements");
            for (int i = 0; i < 4; i++)//row
            {
                for (int j = 0; j < 2; j++)//col
                {
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }


            //Write
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(A[i, j]);
                }
            }
            Console.Read();
        }
    }
}


//SORTING

/*namespace sorting
{
    class check
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
           // for (int i = 0; i < list.Length; i++)
           foreach(int result in list)
            {
                //  Console.WriteLine(list[i] + " ");
                Console.WriteLine(result + " ");
            }
            Console.ReadLine();
        }
    }
}*/
































