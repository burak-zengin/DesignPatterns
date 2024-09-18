using DesignPatterns.Behavioral.Visitor.Components;
using System.Drawing;

namespace DesignPatterns.Behavioral.Visitor.Visitors;

public class ImageVisitor(Graphics graphics) : IVisitor
{
    float y = 0;

    public void Visit(BoxComponent boxComponent)
    {
        y += 1;

        graphics.DrawLine(new Pen(Brushes.Black), 1f, y, 100f, y);

        y += 5;

        foreach (var component in boxComponent.Components)
        {
            component.Execute(this);
        }

        y += 5;

        graphics.DrawLine(new Pen(Brushes.Black), 1f, y, 100f, y);

        y += 5;
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
        graphics.DrawString(priceComponent.List.ToString(), new Font("Arial", 12), Brushes.Red, 1f, y);
        y += 15;
        graphics.DrawString(priceComponent.Sale.ToString(), new Font("Arial", 12), Brushes.Green, 1f, y);
        y += 15;
    }

    public void Visit(TextComponent textComponent)
    {
        graphics.DrawString(textComponent.Text, new Font("Arial", 12), Brushes.Black, 1f, y);
        y += 15;
    }
}
