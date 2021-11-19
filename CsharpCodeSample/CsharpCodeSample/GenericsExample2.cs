using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class GenericsExample2
    {
        public GenericsExample2()
        {
            Dictionary<int, string> list = new Dictionary<int, string>();
            list.Add(101, "Kishor");
            list.Add(102, "Abhijit");
            list.Add(103, "Ajay");
            list.Add(104, "Rushi");
            list.Add(105, "Soham");

            list.Remove(103);

            foreach (var item in list)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }


        }
    }
}
