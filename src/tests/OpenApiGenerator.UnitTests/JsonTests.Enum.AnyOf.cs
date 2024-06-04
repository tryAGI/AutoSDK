using System.Text.Json;
using OpenApiGenerator.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void Enum2_AnyOfStringAndEnum_SystemTextJson_String()
    {
        const string json = "{\"status\":\"pulling 797b70c4edf8\",\"digest\":\"sha256:797b70c4edf85907fe0a49eb85811256f65fa0f7bf52166b147fd16be2be4662\",\"total\":45949216}";

        var response = JsonSerializer.Deserialize<TestEnumClassAnyOf>(json);
        response.Should().NotBeNull();
        response!.Status.Value1.Should().Be(null);
        response!.Status.Value2.Should().Be("pulling 797b70c4edf8");
        response!.Status.Object.Should().Be("pulling 797b70c4edf8");
        
        var responseReverted = JsonSerializer.Deserialize<TestEnumClassAnyOfReverted>(json);
        responseReverted.Should().NotBeNull();
        responseReverted!.Status.Value2.Should().Be(null);
        responseReverted!.Status.Value1.Should().Be("pulling 797b70c4edf8");
        response!.Status.Object.Should().Be("pulling 797b70c4edf8");
    }
    
    [TestMethod]
    public void Enum2_AnyOfStringAndEnum_SystemTextJson_Enum()
    {
        const string json = "{\"status\":\"pulling manifest\",\"digest\":\"sha256:797b70c4edf85907fe0a49eb85811256f65fa0f7bf52166b147fd16be2be4662\",\"total\":45949216}";

        var response = JsonSerializer.Deserialize<TestEnumClassAnyOf>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson(), new TestEnumJsonStringEnumConverter() }
        });
        response.Should().NotBeNull();
        response!.Status.Value1.Should().Be(TestEnum.PullingManifest);
        response!.Status.Value2.Should().Be("pulling manifest");
        response!.Status.Object.Should().Be("pulling manifest");
        
        var responseReverted = JsonSerializer.Deserialize<TestEnumClassAnyOfReverted>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson(), new TestEnumJsonStringEnumConverter() }
        });
        responseReverted.Should().NotBeNull();
        responseReverted!.Status.Value2.Should().Be(TestEnum.PullingManifest);
        responseReverted!.Status.Value1.Should().Be("pulling manifest");
        responseReverted!.Status.Object.Should().Be(TestEnum.PullingManifest);
    }
}

public sealed partial class TestEnumClassAnyOf
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    [global::System.Text.Json.Serialization.JsonConverter(typeof(AnyOfConverterFactorySystemTextJson))]
    public AnyOf<TestEnum?, string> Status { get; set; }
}

public sealed partial class TestEnumClassAnyOfReverted
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    [global::System.Text.Json.Serialization.JsonConverter(typeof(AnyOfConverterFactorySystemTextJson))]
    public AnyOf<string, TestEnum?> Status { get; set; }
}