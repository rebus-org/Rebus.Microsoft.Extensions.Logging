using System;
using Microsoft.Extensions.Logging;
using Rebus.Microsoft.Extensions.Logging;

namespace Rebus.Config
{
    /// <summary>
    /// Configuration extensions for setting up logging with Serilog
    /// </summary>
    public static class MicrosoftExtensionsLoggingConfigurationExtensions
    {
        /// <summary>
        /// Configures Rebus to use Serilog for all of its internal logging, deriving its loggers from the given <see cref="ILogger"/> base logger
        /// </summary>
        public static void MicrosoftExtensionsLogging(this RebusLoggingConfigurer configurer, ILogger logger)
        {
            if (configurer == null) throw new ArgumentNullException(nameof(configurer));
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            configurer.Use(new MicrosoftExtensionsLoggingLoggerFactory(logger));
        }
    }
}