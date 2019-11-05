﻿using Problem_01.Logger.Models.Enums;
using Problem_01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_01.Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        public FileAppender(ILayout layout)
        {
            this.Layout = layout;
            this.File = new LogOut();
        }

        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }

        public LogOut File { get; set; }

        public int Count { get; private set; }

        public void Append(string time, string reportLevel, string message)
        {
            this.Count++;
            string formatMessage = this.Layout.FormatMessage(time, reportLevel, message);
            this.File.Write(formatMessage);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append($"Appender type: {this.GetType().Name}, ")
                .Append($"Layout type: {this.Layout.GetType().Name}, ")
                .Append($"Report level: {this.ReportLevel}, ")
                .Append($"Messages appended: {this.Count}, ")
                .Append($"File size: {this.File.Size}")
                .ToString();
        }
    }
}
