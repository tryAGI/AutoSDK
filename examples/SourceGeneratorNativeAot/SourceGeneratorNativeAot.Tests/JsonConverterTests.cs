using System.Text.Json;

namespace SourceGeneratorNativeAot.Tests;

[TestClass]
public sealed class JsonConverterTests
{
    [TestMethod]
    public void DefaultClientContextUsesGeneratedOneOfConverter()
    {
        const string json = """{"name":"Rex","bark":"woof"}""";
        var context = new PetsClient().JsonSerializerContext;

        var value = JsonSerializer.Deserialize(json, typeof(PetChoice), context);
        value.Should().NotBeNull();

        var serialized = JsonSerializer.Serialize(value, typeof(PetChoice), context);
        using var document = JsonDocument.Parse(serialized);

        document.RootElement.GetProperty("name").GetString().Should().Be("Rex");
        document.RootElement.GetProperty("bark").GetString().Should().Be("woof");
        document.RootElement.TryGetProperty("value1", out _).Should().BeFalse();
        document.RootElement.TryGetProperty("value2", out _).Should().BeFalse();
    }
}
