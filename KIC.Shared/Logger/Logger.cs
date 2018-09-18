using System;
using System.Collections.Generic;
using System.Text;

namespace KIC.Shared.Logger
{
    public class Logger : ILogger
    {
        public void Log(string message, ELogLevel level)
        {
            log(message, level);
        }

        public void Log(Exception ex)
        {
            log(ex.ToString(), ELogLevel.Error);
        }

        public void LogInfo(string message)
        {
            log(message, ELogLevel.Info);
        }

        public void LogWarning(string message)
        {
            log(message, ELogLevel.Warning);
        }

        public void LogError(string message)
        {
            log(message, ELogLevel.Error);
        }

        private void log(string message, ELogLevel level)
        {
            var colorBefore = Console.ForegroundColor;

            switch (level)
            {
                case ELogLevel.Info:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case ELogLevel.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case ELogLevel.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }

            Console.WriteLine(message);

            Console.ForegroundColor = colorBefore;
        }
    }
}
