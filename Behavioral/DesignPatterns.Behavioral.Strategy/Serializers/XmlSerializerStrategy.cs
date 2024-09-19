using System.Xml.Serialization;

namespace DesignPatterns.Behavioral.Strategy.Serializers;

public class XmlSerializerStrategy : ISerializerStrategy
{
    public string Serialize<T>(T data)
    {
        XmlSerializer xmlSerializer = new(typeof(T));

        using (StringWriter stringWriter = new())
        {
            xmlSerializer.Serialize(stringWriter, data);
            return stringWriter.ToString();
        }
    }
}
