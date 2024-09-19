namespace DesignPatterns.Behavioral.Strategy.Serializers;

public class Serializer(ISerializerStrategy serializerStrategy)
{
    private readonly ISerializerStrategy _serializerStrategy = serializerStrategy;

    public string Serialize<T>(T data)
    {
        return _serializerStrategy.Serialize(data);
    }
}
