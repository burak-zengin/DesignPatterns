namespace DesignPatterns.Creational.AbstractFactory.Mercedes;

internal class MercedesFactory : ICarFactory
{
    public IEngine CreateEngine()
    {
        return new MercedesEngine();
    }

    public IWheel CreateWheel()
    {
        return new MercedesWheel();
    }
}
