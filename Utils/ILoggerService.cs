namespace ConfiguratorNewest.Utils
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogDebug(string message);
        void LogError(string message);
    }
}
