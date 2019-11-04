using System;
using System.Linq;

namespace _02._Point_in_rectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = ParseInput();

            Point topLeft = new Point(coordinates[0], coordinates[1]);
            Point bottomRight = new Point(coordinates[2], coordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int numberOfPoints = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPoints; i++)
            {
                int[] point = ParseInput();

                Point pointToChek = new Point(point[0], point[1]);

                Console.WriteLine(rectangle.Contains(pointToChek));
            }
        }

        private static int[] ParseInput()
        {
             return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}

