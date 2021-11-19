using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class CollectionGenerics
    {
        public CollectionGenerics()
        {
            List<int> list = new List<int>(3);
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);

            list.Remove(30);
            //list.RemoveAt(2);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
