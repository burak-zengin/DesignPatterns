namespace DesignPatterns.Structural.Composite.Components;

public class LabelComponent : IComponent
{
    public LabelComponent()
    {
        Components = [];
    }

    public List<IComponent> Components { get; set; }

    public void Execute()
    {
        foreach (var component in Components)
        {
            component.Execute();
        }
    }
}
