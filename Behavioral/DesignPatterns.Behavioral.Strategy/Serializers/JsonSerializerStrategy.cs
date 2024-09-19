using System.Text.Json;

namespace DesignPatterns.Behavioral.Strategy.Serializers;

public class JsonSerializerStrategy : ISerializerStrategy
{
    public string Serialize<T>(T data)
    {
        return JsonSerializer.Serialize(data);
    }
}
