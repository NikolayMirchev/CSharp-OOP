using System;

namespace Problem_3._Wild_Farm.Validations
{
    public class Validator
    {
        public static void GetValidation(string type, string foodType)
        {
            Console.WriteLine($"{type} does not eat {foodType}!");
        }
    }
}
