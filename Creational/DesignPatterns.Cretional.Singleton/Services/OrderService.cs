using DesignPatterns.Creational.Singleton.Models;

namespace DesignPatterns.Creational.Singleton.Services;

public sealed class OrderService
{
    private readonly Random random = new();

    private static OrderService _instance = null;

    private static readonly object _instanceLock = new();

    private static readonly object _methodLock = new();

    OrderService()
    {
    }

    public static OrderService Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    _instance ??= new OrderService();
                }
            }

            return _instance;
        }
    }

    public Order Get()
    {
        Order order;

        lock (_methodLock)
        {
            order = new Order(Guid.NewGuid(), random.Next(100, 500), 
                [
                    new Line(Guid.NewGuid(), "Product", random.Next(1, 5)),
                    new Line(Guid.NewGuid(), "Product", random.Next(1, 5))
                ]
            );
        }

        return order;
    }
}
