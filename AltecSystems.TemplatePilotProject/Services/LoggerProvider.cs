using System;
using System.ComponentModel.Composition;
using System.Linq;
using Ascon.Pilot.SDK;
using NLog;

namespace AltecSystems.TemplatePilotProject.Services
{
    public interface ILoggerProvider
    {
        ILogger GetLogger<T>();
    }

    [Export(typeof(ILoggerProvider))]
    internal class LoggerProvider : ILoggerProvider
    {
        private readonly ILoggerProvider _internalProvider;

        [ImportingConstructor]
        public LoggerProvider(IPilotServiceProvider pilotServiceProvider)
        {
            try
            {
                _internalProvider = pilotServiceProvider.GetServices<ILoggerProvider>().First();
                _internalProvider.GetLogger<LoggerProvider>().Info("Получен ILoggerProvider");
            }
            catch (Exception)
            {
                // Ignore. Использовать NullLogger.
            }
        }

        public ILogger GetLogger<T>()
        {
            if (_internalProvider is null)
            {
                return LogManager.CreateNullLogger();
            }
            return _internalProvider.GetLogger<T>();
        }
    }
}
