using Problem_01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string FormatMessage(string time, string reportLevel, string message)
        {
            return $"{time} - {reportLevel} - {message}";
        }
    }
}
