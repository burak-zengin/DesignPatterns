namespace DesignPatterns.Behavioral.Strategy.Serializers;

public interface ISerializerStrategy
{
    string Serialize<T>(T data);
}
