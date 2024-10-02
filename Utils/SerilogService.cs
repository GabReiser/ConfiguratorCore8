using Serilog;
using Serilog.Events;
using Log = Serilog.Log;

namespace ConfiguratorNewest.Utils
{
    public class SerilogService : ILoggerService
    {
        private readonly ILogger _logger;

        public SerilogService(LogEventLevel logLevel, string logFile)
        {
            // Configura o logger do Serilog com o nível de log especificado
            ConfigureLogging(logLevel, logFile);
            // Inicializa o logger do Serilog
            _logger = Log.Logger;
        }

        public void LogDebug(string message)
        {
            _logger.Debug(message);
        }

        public void LogError(string message)
        {
            _logger.Error(message);
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        private static void ConfigureLogging(LogEventLevel logLevel, string logFile)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Is(logLevel)
                .MinimumLevel.Override("Configurator", LogEventLevel.Information)
                .MinimumLevel.Override("Configurator", LogEventLevel.Error)
                .CreateLogger();
        }
    }
}
