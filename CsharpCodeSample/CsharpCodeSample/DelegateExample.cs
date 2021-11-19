using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    delegate int MyDel(int x, int y);
    class DelegateExample
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x , int y)
        {
            return x * y;
        }
    }
}
