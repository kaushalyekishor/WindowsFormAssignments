using System;
using System.Threading;

namespace CsharpCodeSample
{
    class main
    {
       /* public static void m1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i : " + i);
            }
        }*/
        static void Main(string[] args)
        {
            // Console.WriteLine("Called from main method");
            // DataTypes dt = new DataTypes();
            // Arithmetic am = new Arithmetic();
            // Array a = new Array();
            // Array2 a = new Array2();
            // ArrayRowCol arc = new ArrayRowCol();
            // ArrayRowCol1 arc1 = new ArrayRowCol1();
            // Inheritance2 inh = new Inheritance2();
            // Inheritance2 inh1 = new Inheritance2(10);
            // Methodoverloading m = new Methodoverloading();
            // m.sum(10.1, 20.5);
            // Overriding1 ovr = new Overriding2();
            // ovr.Show();
            // Abstraction_Shape sh = new Square(4);
            // double result = sh.area();
            // Console.Write("{0}", result);
            //  ExceptionExample e = new ExceptionExample();
            //   FileIoExample file = new FileIoExample();
            //  FileIoExample2 file = new FileIoExample2();
            //  ArrayListExample obj = new ArrayListExample();
            //  StackExample obj = new StackExample();
            // QueueExample q = new QueueExample();
            // HashTableExample ht = new HashTableExample();
            // SortedListExample sl = new SortedListExample();
            //  CollectionGenerics cg = new CollectionGenerics();
            //  GenericsExample2 obj = new GenericsExample2();
            //mydel del = new mydel(Add);
            // DelegateExample del = new DelegateExample();  // error
            // MyDel md = new MyDel(Add);  // error
            // GenericDelegate obj = new GenericDelegate();

            /*Action<string> action1 = SampleMethod();
            Func<int, int, int> func1 = Add;
            Predicate<string> pred1 = Login;*/

            // MultithredingExample obj = new MultithredingExample();
            /* Thread t1 = new Thread(new ThreadStart(m1));
             t1.Start();
             Thread.Sleep(3000);

             Thread t2 = new Thread(new ThreadStart(m1));
             t2.Start();
             //t1.Priority = ThreadPriority.Highest;

             Console.WriteLine("Progrma Ended.....");

             for (int i = 0; i <= 10; i++)
             {
                 Console.WriteLine("Main : "+i);
             } */

            // SyncExample sync = new SyncExample();

            DelegateExample1 de = new DelegateExample1();


        }  
    }
}
