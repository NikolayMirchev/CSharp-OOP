using _04.Recharge.Models;
using System;

namespace _04.Recharge
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Ivan Ivanov");
            Robot robot = new Robot("T1000", 100);
            RechargeStation rechargeStation = new RechargeStation();
            rechargeStation.Recharge(robot);

            employee.Work(8);
            robot.Work(24);
            Console.WriteLine(robot.CurrentPower);
        }
    }
}
