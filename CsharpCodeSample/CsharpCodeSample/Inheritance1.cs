using System;

namespace CsharpCodeSample
{
    class Inheritance1
    {
        public Inheritance1()
        {
            Console.WriteLine("Inherigance1 Default constructor");
        }
        public Inheritance1(int a)
        {
            Console.WriteLine("Inherigance1 Parameterized constructor");
        }

        static Inheritance1()
        {
            Console.WriteLine("Inherigance1 static constructor");
        }

       public void method1()
        {
            Console.WriteLine("method1 from Inheritance1");
        }
    }
}
