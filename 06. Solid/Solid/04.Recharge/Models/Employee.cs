using _04.Recharge.Models.Interfaces;
using System;

namespace _04.Recharge.Models
{
    public class Employee : Worker, ISleeper
    {
        public Employee(string id)
            : base(id)
        {
        }

        public void Sleep()
        {
            Console.WriteLine("Employee is sleeping!");
        }
    }
}
