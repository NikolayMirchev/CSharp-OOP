﻿namespace Problem_5._Restaurant
{
    public class Coffee : HotBeverage
    {
        //private const double COFFEE_MILLILITERS = 50;

        //private const decimal COFFEE_PRICE = 3.50M;

        public Coffee(string name, decimal price = 3.5m, double milliliters = 50)
            : base(name, price, milliliters)
        {
            //this.Coffeine = coffeine;
        }

        public double Coffeine { get; set; }

    }
}
