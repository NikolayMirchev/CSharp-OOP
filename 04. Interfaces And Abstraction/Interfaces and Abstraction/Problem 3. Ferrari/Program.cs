using System;

namespace Problem_3._Ferrari
{
    class Program
    {
        static void Main(string[] args)
        {
            string driverName = Console.ReadLine();

            iCar driver = new Ferrari(driverName);

            Console.WriteLine(driver.ToString());
        }
    }
}
