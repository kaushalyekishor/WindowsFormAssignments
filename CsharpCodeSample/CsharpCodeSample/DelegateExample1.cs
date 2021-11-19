using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    //Step 1: Defining a Delegate
    public delegate void AddDelegate(int a, int b);
    public delegate string SayDelegate(string name);
    class DelegateExample1
    {
        public void AddNumes(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static string SayHello(string name)
        {
            return "Hello" + name;
        }

        static void Main(string[] args)
        {
            DelegateExample1 de = new DelegateExample1();

            //2.Instantiating the Delegate
            AddDelegate ad = new AddDelegate(de.AddNumes);
            SayDelegate sd = new SayDelegate(SayHello);

            ad(100, 50);
            string str = sd("Hello");

            Console.WriteLine(str);
        }
    }
}