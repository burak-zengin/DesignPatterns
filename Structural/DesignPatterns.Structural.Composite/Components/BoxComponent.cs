namespace DesignPatterns.Structural.Composite.Components;

public class BoxComponent : IComponent
{
    public BoxComponent()
    {
        Components = [];
    }

    public List<IComponent> Components { get; set; }

    public void Execute()
    {
        Console.WriteLine("********************");

        foreach (var component in Components)
        {
            component.Execute();
        }

        Console.WriteLine("********************");
        Console.WriteLine();
    }
}
