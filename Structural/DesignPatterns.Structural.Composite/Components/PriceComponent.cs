namespace DesignPatterns.Structural.Composite.Components;

public class PriceComponent : IComponent
{
    public decimal List { get; set; }

    public decimal Sale { get; set; }

    public void Execute()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(List);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Sale);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
