using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Sum_Thread
{
    class MyThread
    {
       private int sum, sum1;

        public int Sum { get => sum; }
        public int Sum1 { get => sum1; }
 
        

        public void Sum_Thread1Method() //(object data) :parameter
        {
          //int startValue = (int)data
            int n;
            for(n=1;n<=50;n++)
            {
                sum = sum + n;
            }
            Console.WriteLine("Sum=" + sum);
        }

        public void Sum_Thread2Method()
        {
            int n;
            for (n = 51; n <= 100; n++)
            {
                sum1 = sum1 + n;
            }
            Console.WriteLine("Sum=" + sum1);
        }

      
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            MyThread demoThread = new MyThread();
            Thread  Sum_Thread1 = new Thread(new ThreadStart(demoThread.Sum_Thread1Method));
            //pass the parameter
         // Thread Sum_Thread1 = new Thread((demoThread.Sum_Thread1Method));
            Thread Sum_Thread2 = new Thread(new ThreadStart(demoThread.Sum_Thread2Method));
            Sum_Thread1.Start(); //pass the value  (10)
            Sum_Thread2.Start();

            Sum_Thread1.Join();
            Sum_Thread2.Join();
            int summation= demoThread.Sum + demoThread.Sum1;


            Console.WriteLine("Total:" + summation);
            Console.ReadLine();
        }
    }
}
