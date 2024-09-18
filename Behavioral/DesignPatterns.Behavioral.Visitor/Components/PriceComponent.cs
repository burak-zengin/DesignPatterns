using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Components;

public class PriceComponent : IComponent
{
    public decimal List { get; set; }

    public decimal Sale { get; set; }

    public void Execute(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
