using System;
using System.Threading;

namespace CsharpCodeSample
{
    class SyncExample
    {
        public SyncExample()
        {
            Thread t1 = new Thread(m1);
            t1.Start();

            Thread t2 = new Thread(m2);
            t2.Start();

            t1.Join();
            Console.WriteLine("After Thread1...");

            t2.Join();
            Console.WriteLine("After Thread2...");
            Console.ReadKey();
        }
        public static void m1()
        {
            Console.WriteLine("Thread2 Executed..");
        }
        public static void m2()
        {
            Console.WriteLine("Thread1 Executed..");
        }
    }
}
