namespace DesignPatterns.Structural.Composite.Components;

public class TextComponent : IComponent
{
    public string Text { get; set; }

    public void Execute()
    {
        Console.WriteLine(Text);
    }
}
