using DesignPatterns.Behavioral.Strategy.Models;
using DesignPatterns.Behavioral.Strategy.Serializers;

Product product = new(1, "Product", 1000);

Serializer jsonSerializer = new(new JsonSerializerStrategy());
var json = jsonSerializer.Serialize<Product>(product);

Serializer xmlSerializer = new(new XmlSerializerStrategy());
var xml = xmlSerializer.Serialize(product);

Console.WriteLine("Json:");
Console.WriteLine(json);

Console.WriteLine();

Console.WriteLine("Xml:");
Console.WriteLine(xml);

Console.ReadLine();