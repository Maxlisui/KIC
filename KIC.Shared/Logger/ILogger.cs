using System;

namespace KIC.Shared.Logger
{
    public interface ILogger
    {
        void Log(Exception ex);
        void Log(string message, ELogLevel level);
        void LogError(string message);
        void LogInfo(string message);
        void LogWarning(string message);
    }
}