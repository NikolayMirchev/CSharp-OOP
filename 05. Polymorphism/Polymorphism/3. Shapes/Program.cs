using _3._Shapes.Models;
using System;

namespace _3._Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Shape circle = new Circle(5);
                Shape rectangle = new Rectangle(5, 5);

                Console.WriteLine(circle);
                Console.WriteLine(rectangle);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
