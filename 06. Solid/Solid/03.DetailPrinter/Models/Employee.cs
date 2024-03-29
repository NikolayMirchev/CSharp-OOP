﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _03.DetailPrinter.Models
{
    public class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Name: {this.Name}";
        }
    }
}
