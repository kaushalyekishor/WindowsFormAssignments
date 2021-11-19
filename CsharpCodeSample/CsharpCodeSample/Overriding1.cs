using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpCodeSample
{
    class Overriding1   //parent  class
    {
        public void Show()
        {
            Console.WriteLine("parent class show method");
        }
    }

    class Overriding2 : Overriding1 // child class
    {
        public void Show()
        {
            Console.WriteLine("Chid class Show method");
        }
    }
}
