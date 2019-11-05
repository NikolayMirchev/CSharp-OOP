using _03.DetailPrinter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03.DetailPrinter.Core
{
    public class DetailsPrinter
    {
        private IList<Employee> employees;

        public DetailsPrinter(IList<Employee> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (Employee employee in this.employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
