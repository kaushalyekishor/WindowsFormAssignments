using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class ArrayRowCol1
    {
        public ArrayRowCol1()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[3] { 1, 2, 3 };
            arr[1] = new int[2] { 10, 20 };
            arr[2] = new int[4] { 11, 22, 33, 44 };

            foreach (int[] item in arr)
            {
                foreach (int item1 in item)
                {
                    Console.Write(item1+ "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
