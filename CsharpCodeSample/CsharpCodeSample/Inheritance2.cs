using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class Inheritance2 : Inheritance1
    {
        public Inheritance2()
        {
            Console.WriteLine("Inheritance2 Default Construcor");
        }
        public Inheritance2(int a)
        {
            Console.WriteLine("Inheritance2 Parameterized Construcor");
        }
   
        static Inheritance2()
        {
            Console.WriteLine("Inheritance2 static Construcor");
        }

        public void method2()
        {
            Console.WriteLine("method2 from Inheritance2");
        }
    }
}
