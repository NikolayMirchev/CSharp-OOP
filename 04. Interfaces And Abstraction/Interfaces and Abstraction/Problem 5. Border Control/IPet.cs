using System;

namespace Problem_5._Border_Control
{
    public interface IPet
    {
        string Name { get; set; }

        DateTime Birthday { get; set; }
    }
}