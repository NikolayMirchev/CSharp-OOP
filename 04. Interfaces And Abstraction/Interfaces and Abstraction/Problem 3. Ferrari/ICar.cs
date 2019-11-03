using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_3._Ferrari
{
    public interface iCar
    {
        string Model { get; set; }

        string DriverName { get; set; }

        string Break();

        string Gas();
    }
}
