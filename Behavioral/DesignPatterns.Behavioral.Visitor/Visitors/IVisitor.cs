using DesignPatterns.Behavioral.Visitor.Components;

namespace DesignPatterns.Behavioral.Visitor.Visitors;

public interface IVisitor
{
    void Visit(BoxComponent boxComponent);

    void Visit(LabelComponent labelComponent);

    void Visit(PriceComponent priceComponent);

    void Visit(TextComponent textComponent);
}
