using Problem_10._Explicit_Interfaces.Interfaces;
using System;
using System.Collections.Generic;

namespace Problem_10._Explicit_Interfaces
{
    class Program
    {
        public static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Citizen citizen = new Citizen(inputParts[0], inputParts[1], int.Parse(inputParts[2]));
                citizens.Add(citizen);
                input = Console.ReadLine();
            }

            foreach (Citizen citizen in citizens)
            {
                IPerson person = citizen;
                IResident resident = citizen;
                person.GetName();
                resident.GetName();
            }
        }
    }
}
