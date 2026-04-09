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

    [TestMethod]
    public void OpenEnum_SystemTextJson_PreservesUnknownValue()
    {
        var options = new System.Text.Json.JsonSerializerOptions
        {
            Converters =
            {
                new TestOpenEnumJsonStringEnumConverter(),
                new TestOpenEnumNullableJsonStringEnumConverter(),
            },
        };

        const string json = "\"future-status\"";

        var response = JsonSerializer.Deserialize<TestOpenEnum>(json, options);
        response.Value.Should().Be("future-status");
        response.IsKnown.Should().BeFalse();

        JsonSerializer.Serialize(response, options).Should().Be("\"future-status\"");
    }

    [TestMethod]
    public void OpenEnum_SystemTextJson_SourceGenerationContext_PreservesUnknownValue()
    {
        const string json = "\"future-status\"";

        var response = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.TestOpenEnum);
        response.Should().Be(TestOpenEnum.FromValue("future-status"));
        response.IsKnown.Should().BeFalse();
    }

    [TestMethod]
    public void OpenEnum_NewtonsoftJson_PreservesUnknownValue()
    {
        var settings = new Newtonsoft.Json.JsonSerializerSettings
        {
            Converters =
            {
                new TestOpenEnumNewtonsoftJsonStringEnumConverter(),
                new TestOpenEnumNullableNewtonsoftJsonStringEnumConverter(),
            },
        };

        const string json = "\"future-status\"";

        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<TestOpenEnum>(json, settings);
        response.Value.Should().Be("future-status");
        response.IsKnown.Should().BeFalse();

        Newtonsoft.Json.JsonConvert.SerializeObject(response, settings).Should().Be("\"future-status\"");
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
        typeof(TestOpenEnumJsonStringEnumConverter),
        typeof(TestOpenEnumNullableJsonStringEnumConverter),
        typeof(AnyOfConverterFactorySystemTextJson),
        typeof(UnixTimestampJsonConverterSystemTextJson),
    ])]
[JsonSerializable(typeof(TestOpenEnum))]
[JsonSerializable(typeof(TestEnumClass))]
[JsonSerializable(typeof(TestEnumClassAnyOf))]
[JsonSerializable(typeof(TestEnumClassAnyOfReverted))]
[JsonSerializable(typeof(PullModelResponse))]
[JsonSerializable(typeof(PullModelResponse2))]
[JsonSerializable(typeof(AnyOf<PullModelResponse, PullModelResponse2>))]
[JsonSerializable(typeof(AnyOf<PullModelResponse2, PullModelResponse>))]
[JsonSerializable(typeof(DateTimeOffset))]
internal sealed partial class TestSourceGenerationContext : JsonSerializerContext;
