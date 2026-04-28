using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Honda;
using DesignPatterns.Creational.AbstractFactory.Mercedes;

BuildCar(new HondaFactory());
Console.WriteLine();
BuildCar(new MercedesFactory());

void BuildCar(ICarFactory factory)
{
    var engine = factory.CreateEngine();
    var wheel = factory.CreateWheel();

    Console.WriteLine($"Engine : {engine.Description}, {engine.HorsePower} HP");
    Console.WriteLine($"Wheel  : {wheel.Description}, {wheel.Size} inches");
}
