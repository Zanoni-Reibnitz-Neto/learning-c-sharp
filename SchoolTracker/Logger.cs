using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTracker
{
    internal static class Logger
    {
        private const string DefaultSystemName = "SchoolTracker";
        public static void Log(string message, string system = DefaultSystemName, int priority = 1)
        {
            Console.WriteLine("System: {0}, Priority: {1}, Message: {2}", system, priority, message);
        }
    }
}