using DesignPatterns.Behavioral.Visitor.Components;

namespace DesignPatterns.Behavioral.Visitor.Visitors;

public class ConsoleVisitor : IVisitor
{
    public void Visit(BoxComponent boxComponent)
    {
        Console.WriteLine("********************");

        foreach (var component in boxComponent.Components)
        {
            component.Execute(this);
        }

        Console.WriteLine("********************");
        Console.WriteLine();
    }

    public void Visit(LabelComponent labelComponent)
    {
        foreach (var component in labelComponent.Components)
        {
            component.Execute(this);
        }
    }

    public void Visit(PriceComponent priceComponent)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(priceComponent.List);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(priceComponent.Sale);
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void Visit(TextComponent textComponent)
    {
        Console.WriteLine(textComponent.Text);
    }
}
