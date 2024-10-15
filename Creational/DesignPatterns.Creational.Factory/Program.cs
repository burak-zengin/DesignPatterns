using DesignPatterns.Creational.Factory.Logger;

var consoleLogger = LoggerFactory.Create(SourceType.Console);
consoleLogger.Log("First log.");
consoleLogger.Log("Second log.");

var fileLogger = LoggerFactory.Create(SourceType.File);
fileLogger.Log("First log.");
fileLogger.Log("Second log.");

Console.ReadLine();