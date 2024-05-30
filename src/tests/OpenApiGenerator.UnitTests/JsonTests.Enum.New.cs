using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenApiGenerator.UnitTests;

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

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(TestEnumClass))]
internal sealed partial class TestSourceGenerationContext : JsonSerializerContext;

public sealed partial class TestEnumClass
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    [global::System.Text.Json.Serialization.JsonConverter(typeof(TestEnumJsonStringEnumConverter))]
    public TestEnum? Status { get; set; }
}

public enum TestEnum
{
    PullingManifest,
    Success,
}

public static class TestEnumExtensions
{
    public static string ToValueString(this TestEnum value)
    {
        return value switch
        {
            TestEnum.PullingManifest => "pulling manifest",
            TestEnum.Success => "success",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }
    
    public static TestEnum ToEnum(string value)
    {
        return value switch
        {
            "pulling manifest" => TestEnum.PullingManifest,
            "success" => TestEnum.Success,
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null),
        };
    }
}

internal sealed class TestEnumJsonStringEnumConverter : global::System.Text.Json.Serialization.JsonConverter<TestEnum>
{
    public override TestEnum Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        switch (reader.TokenType)
        {
            case global::System.Text.Json.JsonTokenType.String:
            {
                var stringValue = reader.GetString();
                if (stringValue != null)
                {
                    return TestEnumExtensions.ToEnum(stringValue);
                }
                
                break;
            }
            case global::System.Text.Json.JsonTokenType.Number:
            {
                return (TestEnum)reader.GetInt32();
            }
            default:
                throw new global::System.ArgumentOutOfRangeException();
        }

        return default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        TestEnum value,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToValueString());
    }
}


internal sealed class TestEnumNewtonsoftJsonStringEnumConverter : Newtonsoft.Json.JsonConverter<TestEnum>
{
    public override void WriteJson(JsonWriter writer, TestEnum value, Newtonsoft.Json.JsonSerializer serializer)
    {
        writer.WriteValue(value.ToValueString());
    }

    public override TestEnum ReadJson(JsonReader reader, Type objectType, TestEnum existingValue, bool hasExistingValue,
        Newtonsoft.Json.JsonSerializer serializer)
    {
        if (hasExistingValue)
        {
            return existingValue;
        }
        
        var type = reader.TokenType;

        switch (type)
        {
            case JsonToken.String:
            {
                var stringValue = reader.ReadAsString();
                if (stringValue != null)
                {
                    return TestEnumExtensions.ToEnum(stringValue);
                }
                break;
            }
            case JsonToken.Integer:
            {
                var numValue = reader.ReadAsInt32();
                if (numValue != null)
                {
                    return (TestEnum)numValue.Value;
                }
                
                break;
            }
        }

        return default;
    }
}