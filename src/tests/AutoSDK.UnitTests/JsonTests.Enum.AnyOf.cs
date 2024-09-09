using System.Text.Json;
using System.Text.Json.Serialization;
using AutoSDK.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private readonly JsonSerializerOptions _defaultSystemTextJsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new TestEnumJsonStringEnumConverter(),
            new TestEnumNullableJsonStringEnumConverter(),
        }
    };
    
    [TestMethod]
    public void Enum2_AnyOfStringAndEnum_SystemTextJson_String()
    {
        const string json = "{\"status\":\"pulling 797b70c4edf8\",\"digest\":\"sha256:797b70c4edf85907fe0a49eb85811256f65fa0f7bf52166b147fd16be2be4662\",\"total\":45949216}";
        var response = JsonSerializer.Deserialize<TestEnumClassAnyOf>(json, _defaultSystemTextJsonOptions);
        response.Should().NotBeNull();
        response!.Status.Value1.Should().Be(null);
        response.Status.Value2.Should().Be("pulling 797b70c4edf8");
        response.Status.Object.Should().Be("pulling 797b70c4edf8");
        
        var response2 = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestEnumClassAnyOf);
        response2.Should().NotBeNull();
        response2!.Status.Value1.Should().Be(null);
        response2.Status.Value2.Should().Be("pulling 797b70c4edf8");
        response2.Status.Object.Should().Be("pulling 797b70c4edf8");
        
        var responseReverted = JsonSerializer.Deserialize<TestEnumClassAnyOfReverted>(json, _defaultSystemTextJsonOptions);
        responseReverted.Should().NotBeNull();
        responseReverted!.Status.Value2.Should().Be(null);
        responseReverted.Status.Value1.Should().Be("pulling 797b70c4edf8");
        responseReverted.Status.Object.Should().Be("pulling 797b70c4edf8");
        
        var responseReverted2 = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestEnumClassAnyOfReverted);
        responseReverted2.Should().NotBeNull();
        responseReverted2!.Status.Value2.Should().Be(null);
        responseReverted2.Status.Value1.Should().Be("pulling 797b70c4edf8");
        responseReverted2.Status.Object.Should().Be("pulling 797b70c4edf8");
    }
    
    [TestMethod]
    public void Enum2_AnyOfStringAndEnum_SystemTextJson_Enum()
    {
        const string json = "{\"status\":\"pulling manifest\",\"digest\":\"sha256:797b70c4edf85907fe0a49eb85811256f65fa0f7bf52166b147fd16be2be4662\",\"total\":45949216}";

        var response = JsonSerializer.Deserialize<TestEnumClassAnyOf>(json, _defaultSystemTextJsonOptions);
        response.Should().NotBeNull();
        response!.Status.Value1.Should().Be(TestEnum.PullingManifest);
        response.Status.Value2.Should().Be("pulling manifest");
        response.Status.Object.Should().Be("pulling manifest");
        
        var response2 = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestEnumClassAnyOf);
        response2.Should().NotBeNull();
        response2!.Status.Value1.Should().Be(TestEnum.PullingManifest);
        response2.Status.Value2.Should().Be("pulling manifest");
        response2.Status.Object.Should().Be("pulling manifest");
        
        var responseReverted = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestEnumClassAnyOfReverted);
        responseReverted.Should().NotBeNull();
        responseReverted!.Status.Value2.Should().Be(TestEnum.PullingManifest);
        responseReverted.Status.Value1.Should().Be("pulling manifest");
        responseReverted.Status.Object.Should().Be(TestEnum.PullingManifest);
        
        var responseReverted2 = JsonSerializer.Deserialize<TestEnumClassAnyOfReverted>(json, _defaultSystemTextJsonOptions);
        responseReverted2.Should().NotBeNull();
        responseReverted2!.Status.Value2.Should().Be(TestEnum.PullingManifest);
        responseReverted2.Status.Value1.Should().Be("pulling manifest");
        responseReverted2.Status.Object.Should().Be(TestEnum.PullingManifest);
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