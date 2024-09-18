using DesignPatterns.Behavioral.Visitor.Visitors;

namespace DesignPatterns.Behavioral.Visitor.Components;

public interface IComponent
{
    void Execute(IVisitor visitor);
}
