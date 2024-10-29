using DesignPatterns.Structural.Proxy.Domain.Products;
using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns.Structural.Proxy.Services;

public class ProductRepositoryCachingProxy(IMemoryCache memoryCache) : IProductRepository
{
    private readonly IProductRepository _repository = new ProductRepository();

    public Product GetById(int id)
    {
        var product = memoryCache.Get<Product>(id);

        product ??= _repository.GetById(id);

        memoryCache.Set(id, product);

        return product;
    }
}
