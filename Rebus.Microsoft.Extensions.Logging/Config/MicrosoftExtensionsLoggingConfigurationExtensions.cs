using System;
using Microsoft.Extensions.Logging;
using Rebus.Microsoft.Extensions.Logging;
// ReSharper disable UnusedMember.Global

namespace Rebus.Config
{
    /// <summary>
    /// Configuration extensions for setting up logging with Serilog
    /// </summary>
    public static class MicrosoftExtensionsLoggingConfigurationExtensions
    {
        /// <summary>
        /// Configures Rebus to use Microsoft Extensions Logging for all of its internal logging, used the given <paramref name="logger"/> for everything
        /// </summary>
        public static void MicrosoftExtensionsLogging(this RebusLoggingConfigurer configurer, ILogger logger)
        {
            if (configurer == null) throw new ArgumentNullException(nameof(configurer));
            if (logger == null) throw new ArgumentNullException(nameof(logger));
            configurer.Use(new MicrosoftExtensionsLoggingLoggerFactory(logger));
        }

        /// <summary>
        /// Configures Rebus to use Microsoft Extensions Logging for all of its internal logging, used the given <paramref name="loggerFactory"/> to create
        /// typed loggers to use
        /// </summary>
        public static void MicrosoftExtensionsLogging(this RebusLoggingConfigurer configurer, ILoggerFactory loggerFactory)
        {
            if (configurer == null) throw new ArgumentNullException(nameof(configurer));
            if (loggerFactory == null) throw new ArgumentNullException(nameof(loggerFactory));
            configurer.Use(new MicrosoftExtensionsLoggingLoggerFactory(loggerFactory));
        }
    }
}