using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class GenericDelegate
    {
        public static void sampleMethod(string name)
        {
            Console.WriteLine("Welcome " +name);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static bool Login(string uid)
        {
            if (uid == "kishor")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
