using System;

namespace Problem_3._Players_and_Monsters
{
    class Program
    {
        static void Main(string[] args)
        {
            DarkWizard darkWizard = new DarkWizard("Dark", 30);

            SoulMaster soul = new SoulMaster("Soul", 20);
            Console.WriteLine(soul);
            Console.WriteLine(darkWizard);
        }
    }
}
