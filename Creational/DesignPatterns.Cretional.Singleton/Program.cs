using DesignPatterns.Creational.Singleton.Services;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    return OrderService.Instance.Get();
});

app.Run();