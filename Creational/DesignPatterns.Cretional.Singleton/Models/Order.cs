namespace DesignPatterns.Creational.Singleton.Models;

public record Order(Guid Id, decimal Amount, List<Line> Lines);
