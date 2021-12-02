namespace Exam.Payments.WebApi.Domain.Logger
{
    public interface ILogManager
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
