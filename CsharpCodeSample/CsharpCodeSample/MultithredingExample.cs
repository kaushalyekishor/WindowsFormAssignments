using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class MultithredingExample
    {
        public static void m1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("i : "+i);
            }
        }
    }
}
