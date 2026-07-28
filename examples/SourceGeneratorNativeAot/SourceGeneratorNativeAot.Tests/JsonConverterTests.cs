using System.Text.Json;

namespace SourceGeneratorNativeAot.Tests;

[TestClass]
public sealed class JsonConverterTests
{
    [TestMethod]
    public void DefaultClientContextUsesGeneratedOneOfConverter()
    {
        const string json = """{"name":"Rex","bark":"woof","mood":"playful"}""";
        var context = new PetsClient().JsonSerializerContext;

        var value = JsonSerializer.Deserialize(json, typeof(PetChoice), context);
        value.Should().NotBeNull();

        var serialized = JsonSerializer.Serialize(value, typeof(PetChoice), context);
        using var document = JsonDocument.Parse(serialized);

        document.RootElement.GetProperty("name").GetString().Should().Be("Rex");
        document.RootElement.GetProperty("bark").GetString().Should().Be("woof");
        document.RootElement.GetProperty("mood").GetString().Should().Be("playful");
        document.RootElement.TryGetProperty("value1", out _).Should().BeFalse();
        document.RootElement.TryGetProperty("value2", out _).Should().BeFalse();
    }

    [TestMethod]
    public void DefaultClientContextUsesGeneratedAnyOfConverter()
    {
        const string json = """{"name":"Milo","lives":9,"mood":"sleepy"}""";
        var context = new PetsClient().JsonSerializerContext;

        var value = JsonSerializer.Deserialize(json, typeof(PetMatch), context);
        value.Should().NotBeNull();

        var serialized = JsonSerializer.Serialize(value, typeof(PetMatch), context);
        using var document = JsonDocument.Parse(serialized);

        document.RootElement.GetProperty("name").GetString().Should().Be("Milo");
        document.RootElement.GetProperty("lives").GetInt32().Should().Be(9);
        document.RootElement.GetProperty("mood").GetString().Should().Be("sleepy");
        document.RootElement.TryGetProperty("value1", out _).Should().BeFalse();
        document.RootElement.TryGetProperty("value2", out _).Should().BeFalse();
    }

    [TestMethod]
    public void DefaultClientContextUsesGeneratedEnumConverter()
    {
        var context = new PetsClient().JsonSerializerContext;

        var value = JsonSerializer.Deserialize("\"sleepy\"", typeof(PetMood), context);
        value.Should().NotBeNull();

        JsonSerializer.Serialize(value, typeof(PetMood), context)
            .Should().Be("\"sleepy\"");
    }
}
