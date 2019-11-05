using Problem_01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Problem_01.Logger.Factories
{
    public class AppenderFactory
    {
        public IAppender CreateAppender(string appenderType, ILayout layout)
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(a => a.Name == appenderType);
            return (IAppender)Activator.CreateInstance(type, layout);
        }
    }
}
