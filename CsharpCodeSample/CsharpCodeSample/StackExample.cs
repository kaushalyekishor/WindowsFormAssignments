using System;
using System.Collections;
using System.Text;

namespace CsharpCodeSample
{
    class StackExample
    {
        public StackExample()
        {
            Stack s = new Stack();
            s.Push("One");
            s.Push("Two");
            s.Push("Three");
            s.Push("Four");
            s.Push("Five");
            s.Pop();

            Object top = s.Peek();
            Console.WriteLine(top);

            Console.WriteLine("This is Stack Example");
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
        }
    }
}