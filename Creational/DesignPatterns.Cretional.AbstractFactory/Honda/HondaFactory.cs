namespace DesignPatterns.Creational.AbstractFactory.Honda;

internal class HondaFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new HondaEngine();
    }

    public IWheel CreateWheel()
    {
        return new HondaWheel();
    }
}
