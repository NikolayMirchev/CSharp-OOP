using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Interfaces
{
    public interface ILayout
    {
        string FormatMessage(string time, string reportLevel, string message);
    }
}
