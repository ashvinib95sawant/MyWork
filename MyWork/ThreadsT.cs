using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MyWork
{
    class DemoThread
    {
        static void m1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            Thread t1 = new Thread(m1);
            t1.Start();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("GM");
            }
            Console.WriteLine("Main Ends");
        }
    }


    // 2.

    class thread2
    {
        public static void m1()
        {
            for (int i = 1; i <= 30; i = i + 2)
            {
                Console.WriteLine("Odd " + i + Thread.CurrentThread.Name);
            }
        }

        static void Main(string[] args)
        {
            Thread main = Thread.CurrentThread;
            Thread tt1 = new Thread(m1);
            tt1.Name = "Om";
            Console.WriteLine("Priority= " + tt1.Priority);

            Thread t2 = new Thread(m1);
            t2.Name = "Omkar";
            t2.Priority = ThreadPriority.Highest;
            tt1.Start();
            t2.Start();

            Thread.Sleep(1000);
            for (int i = 2; i <= 30; i = i + 2)
                Console.WriteLine(i);

            /*Thread t3 = new Thread(m1);
            t3.IsBackground = true; //Helper
            t3.Start();*/
        }
    }

    //3.
    class DemoJoin
    {
        static void m1()
        {
            for (int i = 1; i <= 20; i = i + 2)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts");
            Thread th1 = new Thread(m1);
            th1.Start();
            th1.Join();

            for (int i = 200; i <= 220; i = i + 2)
                Console.WriteLine("Main "+i);
        }
    }
}
