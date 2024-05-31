using Microsoft.Extensions.Logging;
using System;

public class CustomLoggerProvider : ILoggerProvider
{
    public ILogger CreateLogger(string categoryName)
    {
        return new CustomLogger();
    }

    public void Dispose()
    {
    }
}

public class CustomLogger : ILogger
{
    public IDisposable BeginScope<TState>(TState state) => null;

    public bool IsEnabled(LogLevel logLevel) => true;  // Ajuste conforme necessário

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        if (!IsEnabled(logLevel))
        {
            return;
        }

        var message = formatter(state, exception);

        // Filtrar mensagens que contêm "Erro"
        if (message.Contains("Sucesso") || message.Contains("Erro") || message.Contains("Vazio"))
        {
            Console.WriteLine(message);
        }
    }
}
