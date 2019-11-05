using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Interfaces
{
    public interface ILogger
    {
        void Error(string time, string message);

        void Info(string time, string message);

        void Critical(string time, string message);

        void Fatal(string time, string message);

        void Warning(string time, string message);
    }
}
