using System.Text.Json;
using AnyOfTypes;
using OpenApiGenerator.JsonConverters;
using JsonException = System.Text.Json.JsonException;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void OneOf_OfficialExample_Valid1_SystemTextJson()
    {
        const string json = "{\n  \"bark\": true,\n  \"breed\": \"Dingo\" \n}";
        var response = JsonSerializer.Deserialize<OneOf<Dog, Cat>>(json, new JsonSerializerOptions
        {
            Converters = { new OneOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.Validate().Should().BeTrue();
        response.IsFirst.Should().BeTrue();
        response.First.Should().NotBeNull();
        response.First!.bark.Should().BeTrue();
        response.First!.breed.Should().Be("Dingo");
        response.IsSecond.Should().BeFalse();
        response.Second.Should().BeNull();
    }
    
    [TestMethod]
    public void OneOf_OfficialExample_NotValid1_SystemTextJson()
    {
        const string json = "{\n  \"bark\": true,\n  \"hunts\": true\n}";
        var deserialization = () => JsonSerializer.Deserialize<OneOf<Dog, Cat>>(json, new JsonSerializerOptions
        {
            Converters = { new OneOfConverterFactorySystemTextJson() }
        });
        deserialization.Should().Throw<JsonException>();
    }
    
    [TestMethod]
    public void OneOf_OfficialExample_NotValid2_SystemTextJson()
    {
        const string json = "{\n  \"bark\": true,\n  \"hunts\": true,\n  \"breed\": \"Husky\",\n  \"age\": 3 \t\t\n}";
        var deserialization = () => JsonSerializer.Deserialize<OneOf<Dog, Cat>>(json, new JsonSerializerOptions
        {
            Converters = { new OneOfConverterFactorySystemTextJson() }
        });
        deserialization.Should().Throw<JsonException>();
    }
}

public class Dog
{
    [Newtonsoft.Json.JsonRequired]
    public required string breed { get; set; }
    [Newtonsoft.Json.JsonRequired]
    public required bool? bark { get; set; }
}

public class Cat
{
    [Newtonsoft.Json.JsonRequired]
    public required bool? hunts { get; set; }
    [Newtonsoft.Json.JsonRequired]
    public required int? age { get; set; }
}