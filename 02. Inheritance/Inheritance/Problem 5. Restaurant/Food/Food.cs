﻿namespace Problem_5._Restaurant.Food
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams)
            : base(name, price)
        {
            this.Grams = grams;
        }

        public double Grams { get; set; }
    }
}