using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            IDrawable shape = new Rectangle(10, 5);

            shape.Draw();
        }
    }
}
