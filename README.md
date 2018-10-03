# Rebus.Microsoft.Extensions.Logging

[![install from nuget](https://img.shields.io/nuget/v/Rebus.Microsoft.Extensions.Logging.svg?style=flat-square)](https://www.nuget.org/packages/Rebus.Microsoft.Extensions.Logging)

Provides a Microsoft Extensions Logging logging integration for [Rebus](https://github.com/rebus-org/Rebus).

![](https://raw.githubusercontent.com/rebus-org/Rebus/master/artwork/little_rebusbus2_copy-200x200.png)

---

Like this:

```csharp
var loggerFactory = new LoggerFactory()
	.AddConsole();

Configure.With(...)
	.Logging(l => l.MicrosoftExtensionsLogging(loggerFactory))
	.Transport(t => t.Use(...))
	.(...)
	.Start();
```

or like this:


```csharp
var logger = new LoggerFactory()
	.AddConsole()
	.CreateLogger<Program>();

Configure.With(...)
	.Logging(l => l.MicrosoftExtensionsLogging(logger))
	.Transport(t => t.Use(...))
	.(...)
	.Start();
```
