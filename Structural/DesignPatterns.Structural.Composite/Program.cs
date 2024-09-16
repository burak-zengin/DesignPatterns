using DesignPatterns.Structural.Composite.Components;

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

labelComponent.Execute();

Console.ReadLine();