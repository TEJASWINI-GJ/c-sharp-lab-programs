using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace synchronization
{
    class MyThread
    {
        private int sum = 100;
        Mutex mut = new Mutex();

        public int Sum{ get => sum; }

        public void Sum_Thread1Method() //(object data) :parameter
        {
            mut.WaitOne();
            sum -= 20;
            mut.ReleaseMutex();
        }

        public void Sum_Thread2Method()
        {
            mut.WaitOne();
            int temp = sum;
            Thread.Sleep(1000);
            temp += 40;
            sum = temp;
            mut.ReleaseMutex();
            Thread.Sleep(1000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread demoThread = new MyThread();
            
            Thread Sum_Thread1 = new Thread((demoThread.Sum_Thread1Method));
            Thread Sum_Thread2 = new Thread(new ThreadStart(demoThread.Sum_Thread2Method));
            Sum_Thread1.Priority = ThreadPriority.Highest;
            Sum_Thread2.Priority = ThreadPriority.Lowest;
            Sum_Thread1.Start();
            Sum_Thread2.Start();

            Sum_Thread1.Join();
            Sum_Thread2.Join();



            Console.WriteLine("Result:" + demoThread.Sum);
            Console.ReadLine();
        }
    }
}
