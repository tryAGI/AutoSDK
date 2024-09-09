using System.Text.Json.Serialization;
using AutoSDK.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void Enum2_SystemTextJson()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        var response = JsonSerializer.Deserialize<TestEnumClass>(json);
        response.Should().NotBeNull();
        response!.Status.Should().Be(TestEnum.PullingManifest);
    }
    
    
    [TestMethod]
    public void Enum2_SystemTextJson_SourceGenerationContext()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        var response = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestEnumClass);
        response.Should().NotBeNull();
        response!.Status.Should().Be(TestEnum.PullingManifest);
    }
    
    // [TestMethod]
    // public void Enum2_NewtonsoftJson()
    // {
    //     const string json = "{\n  \"status\": \"pulling manifest\"\n}";
    //
    //     var response = Newtonsoft.Json.JsonConvert.DeserializeObject<TestEnumClass>(json, new TestEnumNewtonsoftJsonStringEnumConverter());
    //     response.Should().NotBeNull();
    //     response!.Status.Should().Be(TestEnum.PullingManifest);
    // }
}

[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    Converters =
    [
        typeof(TestEnumJsonStringEnumConverter),
        typeof(TestEnumNullableJsonStringEnumConverter),
        typeof(AnyOfConverterFactorySystemTextJson),
        typeof(UnixTimestampJsonConverterSystemTextJson),
    ])]
[JsonSerializable(typeof(TestEnumClass))]
[JsonSerializable(typeof(TestEnumClassAnyOf))]
[JsonSerializable(typeof(TestEnumClassAnyOfReverted))]
[JsonSerializable(typeof(PullModelResponse))]
[JsonSerializable(typeof(PullModelResponse2))]
[JsonSerializable(typeof(AnyOf<PullModelResponse, PullModelResponse2>))]
[JsonSerializable(typeof(AnyOf<PullModelResponse2, PullModelResponse>))]
[JsonSerializable(typeof(DateTimeOffset))]
internal sealed partial class TestSourceGenerationContext : JsonSerializerContext;
