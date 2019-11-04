using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3._Wild_Farm.Animals.Mammals.Felines
{
    public abstract class Feline : Mammal
    {
        private string breed;

        protected Feline(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }
    }
}
