using Problem_01.Logger.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevel ReportLevel { get; set; }

        void Append(string time, string reportLevel, string message);
    }
}
