using System.Text.Json;
using AutoSDK.JsonConverters;
using AutoSDK.UnitTests.OneOf;
using JsonException = System.Text.Json.JsonException;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void OneOf_OfficialExample_Valid1_SystemTextJson()
    {
        var response = JsonSerializer.Deserialize<OneOf<Dog, Cat>>(/*language=json*/
            """
            {
              "bark": true,
              "breed": "Dingo"
            }
            """, new JsonSerializerOptions
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
        var deserialization = () => JsonSerializer.Deserialize<OneOf<Dog, Cat>>(/*language=json*/
            """
            {
              "bark": true,
              "hunts": true
            }
            """, new JsonSerializerOptions
        {
            Converters = { new OneOfConverterFactorySystemTextJson() }
        });
        deserialization.Should().Throw<JsonException>();
    }
    
    [TestMethod]
    public void OneOf_OfficialExample_NotValid2_SystemTextJson()
    {
        var deserialization = () => JsonSerializer.Deserialize<OneOf<Dog, Cat>>(/*language=json*/
            """
            {
              "bark": true,
              "hunts": true,
              "breed": "Husky",
              "age": 3
            }
            """, new JsonSerializerOptions
        {
            Converters = { new OneOfConverterFactorySystemTextJson() }
        });
        deserialization.Should().Throw<JsonException>();
    }
}