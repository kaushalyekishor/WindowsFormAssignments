using System;

namespace CsharpCodeSample
{
    abstract class Abstraction_Shape
    {
        public abstract int area();
    }

    class Square : Abstraction_Shape
    {
        private int side;

        public Square( int x = 0)
        {
            side = x;
        }

        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
}
