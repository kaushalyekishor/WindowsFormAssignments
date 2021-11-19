using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class Array2
    {
        public Array2()
      {
            int[] arr = new int[] {7,3,5,1,9,2};
            Console.WriteLine("Entr the number to be search:");
            int num = int.Parse(Console.ReadLine());
            bool found = false;

            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    //Console.WriteLine("Element Found");
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Element Found");
            }
            else
            {
                Console.WriteLine("Element Not Found");
            }

      }
    }
}
