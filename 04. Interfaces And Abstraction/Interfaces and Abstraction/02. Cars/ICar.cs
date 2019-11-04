using System;
using System.Collections.Generic;
using System.Text;

namespace _02._Cars
{
    public interface ICar
    {
        string Model { get; set; }
        string Color { get; set; }

        string Start();
        string Stop();

    }
}
