namespace DesignPatterns.Creational.Factory.Logger;

internal class FileLogger : ILogger
{
    void ILogger.Log(string message)
    {
        File.AppendAllLines(@"Log.txt", [message]);
    }
}
