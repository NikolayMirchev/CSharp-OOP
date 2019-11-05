using _03.DetailPrinter.Core;
using _03.DetailPrinter.Models;
using System;
using System.Collections.Generic;

namespace _03.DetailPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee("Pesho");
            Employee secondEmployee = new Employee("Ivan");
            Manager manager = new Manager("Gosho", new List<string>() { "data.txt", "preview.pptx", "salaries.xsl" });
            IList<Employee> employees = new List<Employee>() { firstEmployee, secondEmployee, manager };
            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
