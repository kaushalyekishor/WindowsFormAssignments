
using System;

namespace CsharpCodeSample
{
    class Array
    {
        public Array()
        {
            int[] arr1 = new int[] { 7, 3, 5, 1, 9, 2 };
            int temp;
            //Console.WriteLine(arr1[0]);
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.Write("{0} ", arr1[i]);
            //}
            //Console.WriteLine();
            //foreach (int item in arr1)
            //{
            //    Console.Write("{0} ", item);
            //}
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr1.Length-1; j++)
                {
                    if (arr1[j] > arr1[j+1])
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
                 Console.WriteLine();
            foreach (int item in arr1)
            {
                Console.Write("{0} ", item);
            }



        }
    }
}
