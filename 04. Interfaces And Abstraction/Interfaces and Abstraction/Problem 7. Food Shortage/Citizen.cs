﻿using System;

namespace Problem_7._Food_Shortage
{
    public class Citizen : AbstractCitizen, IBuyer
    {
        public Citizen(string name, int age, long id, DateTime birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
            Food = 0;
        }

        public long Id { get; set; }

        public DateTime Birthday { get; set; }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}