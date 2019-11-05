using _02.GraphicEditor.Models.Interfaces;
using System;

namespace _02.GraphicEditor.Models
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine($"I'm {this.GetType().Name}");
        }
    }
}
