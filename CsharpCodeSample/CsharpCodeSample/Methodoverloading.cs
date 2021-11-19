using System;

namespace CsharpCodeSample
{
    class Methodoverloading
    {
        public void sum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
       public void sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }

}
