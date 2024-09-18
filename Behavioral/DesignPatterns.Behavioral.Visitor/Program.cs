using DesignPatterns.Behavioral.Visitor.Components;
using DesignPatterns.Behavioral.Visitor.Visitors;
using System.Drawing;

LabelComponent labelComponent = new();

BoxComponent headerBoxComponent = new();
TextComponent headerTextComponent = new()
{
    Text = "İ N D İ R İ M"
};
headerBoxComponent.Components.Add(headerTextComponent);

BoxComponent bodyBoxComponent = new();
TextComponent nameTextComponent = new()
{
    Text = "15' LAPTOP"
};
PriceComponent priceTextComponent = new()
{
    List = 1000,
    Sale = 750
};
bodyBoxComponent.Components.Add(nameTextComponent);
bodyBoxComponent.Components.Add(priceTextComponent);

labelComponent.Components.Add(headerBoxComponent);
labelComponent.Components.Add(bodyBoxComponent);

ConsoleVisitor consoleVisitor = new();
labelComponent.Execute(consoleVisitor);

Bitmap bitmap = new(100, 100);
Graphics graphics = Graphics.FromImage(bitmap);
graphics.Clear(Color.White);

ImageVisitor imageVisitor = new(graphics);
labelComponent.Execute(imageVisitor);

bitmap.Save(@"..\..\..\Label.jpg");

Console.ReadLine();