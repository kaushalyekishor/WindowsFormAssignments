using System;
using System.Collections;
using System.Text;

namespace CsharpCodeSample
{
    class ArrayListExample
    {
        public ArrayListExample()
        {
            ArrayList list = new ArrayList();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add("Four");
            list.Add("Five");

            // Console.WriteLine(list);
            //list.Remove("Three");
            //list.RemoveAt(3);
            //list.RemoveRange(0, 2);
            //list.Sort();
            //list.Reverse(); 
            int count  = list.Count;
            int capacity = list.Capacity;
            Console.WriteLine("Count: "+count);
            Console.WriteLine("Capacity:"+ capacity);

            list.TrimToSize();
            capacity = list.Capacity;
            Console.WriteLine("Capacity:" + capacity);

            foreach (var item in list)
            {
                Console.Write(item+", ");
            }

        }
    }
}
