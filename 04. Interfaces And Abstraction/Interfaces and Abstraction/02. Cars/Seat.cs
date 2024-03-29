﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Cars
{
    public class Seat : Car, ICar
    {
        
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }
        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}
