using Problem_01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Problem_01.Logger.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(l => l.Name == layoutType);
            return (ILayout)Activator.CreateInstance(type);
        }
    }
}
