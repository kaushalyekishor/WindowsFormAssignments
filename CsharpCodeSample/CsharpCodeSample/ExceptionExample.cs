using System;

namespace CsharpCodeSample
{
    class ExceptionExample
    {
        public ExceptionExample()
        {
            Console.WriteLine("Enter 1st No: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2dn No: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Divide by zero is not allowed");
            }
            Console.WriteLine("Result is:{0} ",result);
        }
    }
}