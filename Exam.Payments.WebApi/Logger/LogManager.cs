using Exam.Payments.WebApi.Domain.Logger;
using NLog;

namespace Exam.Payments.WebApi.Host.Logger
{
    public class LogManager : ILogManager
    {
        private static ILogger logger = NLog.LogManager.GetCurrentClassLogger();

        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        public void LogError(string message)
        {
            logger.Error(message);
        }

        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        public void LogWarning(string message)
        {
            logger.Warn(message);
        }
    }
}
