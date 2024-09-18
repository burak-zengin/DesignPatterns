using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Components;

public class TextComponent : IComponent
{
    public string Text { get; set; }

    public void Execute(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
