namespace DesignPatterns.Creational.Factory.Logger;

internal class ConsoleLogger : ILogger
{
    void ILogger.Log(string message)
    {
        Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
    }
}
