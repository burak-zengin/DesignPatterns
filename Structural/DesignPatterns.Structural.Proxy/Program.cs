using DesignPatterns.Structural.Proxy.Domain.Products;
using DesignPatterns.Structural.Proxy.Services;
using Microsoft.Extensions.DependencyInjection;

static IServiceProvider ConfigureServiceCollection()
{
    ServiceCollection serviceCollection = new();
    serviceCollection.AddScoped<IProductRepository, ProductRepositoryCachingProxy>();
    serviceCollection.AddMemoryCache();
    return serviceCollection.BuildServiceProvider();
}

var serviceCollection = ConfigureServiceCollection();
using (var scope = serviceCollection.CreateScope())
{
    IProductRepository repository = scope.ServiceProvider.GetRequiredService<IProductRepository>();

    Product product = repository.GetById(1);
}