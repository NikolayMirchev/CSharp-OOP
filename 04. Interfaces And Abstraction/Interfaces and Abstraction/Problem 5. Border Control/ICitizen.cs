using System;

namespace Problem_5._Border_Control
{
    public interface ICitizen
    {
        string Name { get; set; }

        int Age { get; set; }

        long Id { get; set; }

        DateTime Birthday { get; set; }
    }
}