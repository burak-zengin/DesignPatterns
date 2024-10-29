using DesignPatterns.Structural.Proxy.Domain.Products;

namespace DesignPatterns.Structural.Proxy.Services;

public class ProductRepository : IProductRepository
{
    public Product GetById(int id)
    {
        return new Product
        {
            Id = id,
            Name = "Test",
            UnitPrice = 1000
        };
    }
}
