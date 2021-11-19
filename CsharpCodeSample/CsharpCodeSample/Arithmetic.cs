using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class Arithmetic
    {
        public Arithmetic()
        {
            int a = 50;
            int b = 10;
            /* Console.WriteLine("sum is:{0}", (a + b));
             Console.WriteLine("sub is:{0}", (a - b));
             Console.WriteLine("mul is:{0}", (a * b));
             Console.WriteLine("div is:{0}", (a / b));
             Console.WriteLine("mod is:{0}", (a % b));*/

            /*int pre = ++a;
            int post = a++;
            Console.WriteLine("pre:{0} and post:{1}",pre,post);*/

            /* Console.WriteLine(a > b);
             Console.WriteLine(a < b);
             Console.WriteLine(a ==  b);
             Console.WriteLine(a != b);
             Console.WriteLine(a <= b);
            Console.WriteLine(a >= b); */

            //Ternary operator
            /*  int num = 46;
              string s = num % 2 == 0 ? "Even" : "odd";
              Console.WriteLine(s); */

            //logical operator
            Console.WriteLine("AND");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(true && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(false && false);
            Console.WriteLine();
            Console.WriteLine("OR");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(true || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(false || false);
        }
    }
}
