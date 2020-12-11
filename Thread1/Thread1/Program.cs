using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread1
{
    class MyThread
    {
        //this method  will be executed when you start the thread1
        public void Thread1Method(object state)
        {
            Console.Write(Thread.CurrentThread.Name);
            int t1=100;
            for(int i=1;i<t1;i+=2)
            {
                Console.WriteLine("inside thread1:" + i);
            }
        }

        //this method  will be executed when you start the thread2
        public void Thread2Method(object state)
        {
            Console.Write(Thread.CurrentThread.Name);
            int t2 = 100;
            for (int i = 2; i < t2; i += 2)
            {
                Console.WriteLine("inside thread2:" + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread demoThread = new MyThread();

            //Thread Creation
           /* Thread thread1 = new Thread(new ThreadStart(demoThread.Thread1Method));
             Thread1.Name = "Thread1";
            Thread thread2 = new Thread(new ThreadStart(demoThread.Thread2Method));
            Thread2.Name = "Thread2";
            
            //start the threads
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Name of the Thread1"+thread1.Name);
            Console.WriteLine("Name of the Thread1"+thread1.Name);
            
            //after starting both the thread the main thread will continue
            thread1.Join();
            thread2.Join();*/

           // ThreadPool.QueueUserWorkItem(demoThread.Thread1Method);
           // ThreadPool.QueueUserWorkItem(demoThread.Thread2Method);
            Console.WriteLine("main thread is exiting");
            Console.ReadLine();
        }
    }
}
