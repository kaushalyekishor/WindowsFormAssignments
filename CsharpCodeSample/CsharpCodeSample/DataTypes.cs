using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class DataTypes
    {
        public DataTypes()
        {
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine(); //object type
            Console.WriteLine("Enter the Age: ");
            int age = int.Parse(Console.ReadLine()); // value tyep

            Console.WriteLine("User name is {0} \nUser Age is {1}", name, age);
        }
      
    }
}
