namespace DesignPatterns.Structural.Proxy.Domain.Products;

public interface IProductRepository
{
    public Product GetById(int id);
}
