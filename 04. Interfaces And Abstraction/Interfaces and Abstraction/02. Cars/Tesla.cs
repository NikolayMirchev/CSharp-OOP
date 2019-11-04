using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Cars
{
    public class Tesla : Car, ICar, IElectricCar
    {
        public int Battery { get; set; }

        public Tesla(string model, string color, int batteries)
        {
            Model = model;
            Color = color;
            Battery = batteries;
        }
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Color} Tesla {Model} with {Battery} Batteries");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
