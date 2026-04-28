namespace DesignPatterns.Creational.AbstractFactory;

internal interface ICarFactory
{
    IEngine CreateEngine();

    IWheel CreateWheel();
}
