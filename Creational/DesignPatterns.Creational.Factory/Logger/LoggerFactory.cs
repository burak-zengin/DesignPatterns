namespace DesignPatterns.Creational.Factory.Logger;

internal class LoggerFactory
{
    internal static ILogger Create(SourceType sourceType)
    {
        switch (sourceType)
        {
            case SourceType.Console:
                return new ConsoleLogger();
            case SourceType.File:
                return new FileLogger();
            default:
                throw new ArgumentException("Unsupported source type.");
        }
    }
}
