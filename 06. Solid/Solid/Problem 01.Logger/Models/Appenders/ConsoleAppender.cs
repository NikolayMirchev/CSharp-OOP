﻿using Problem_01.Logger.Models.Enums;
using Problem_01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout)
        {
            this.Layout = layout;
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public int Count { get; private set; }

        public void Append(string time, string reportLevel, string message)
        {
            this.Count++;
            string formatMessage = this.Layout.FormatMessage(time, reportLevel, message);
            Console.WriteLine(formatMessage);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel}, ")
                .Append($"Messages appended: {this.Count}, ")
                .ToString();
        }
    }
}
