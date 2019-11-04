using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3._Wild_Farm.Animals.Mammals
{
    public abstract class Mammal : Animal
    {
        private string livingRegion;

        protected Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            this.LivingRegion = livingRegion;
        }

        public string LivingRegion
        {
            get { return this.livingRegion; }
            set { this.livingRegion = value; }
        }
    }
}
