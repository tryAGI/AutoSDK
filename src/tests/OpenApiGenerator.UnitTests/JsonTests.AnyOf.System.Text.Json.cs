using System.Text.Json;
using System.Text.Json.Serialization;
using AnyOfTypes;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void AnyOf2_First_SystemTextJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>(new PullModelResponse2
        {
            Status = PullModelResponseStatus2.PullingManifest,
        });

        var json = JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("{\"status\":\"pulling manifest\"}");
        var response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        response.First.Should().NotBeNull();
        response.First!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
    }
    
    [TestMethod]
    public void AnyOf2_Second_SystemTextJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>(new PullModelResponse
        {
            Status = PullModelResponseStatus.PullingManifest,
        });

        var json = JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("{\"status\":0}");
        var response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        response.Second.Should().NotBeNull();
        response.Second!.Status.Should().Be(PullModelResponseStatus.PullingManifest);
    }
    
    [TestMethod]
    public void AnyOf2_Undefined_SystemTextJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>();

        var json = JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("\"null\"");
        var response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        response.IsUndefined.Should().BeTrue();
    }
}

public class AnyOfConverterSystemTextJson<T1, T2> : JsonConverter<AnyOf<T1, T2>>
{
    public override AnyOf<T1, T2> Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        try
        {
            return JsonSerializer.Deserialize<T1>(ref reader)!;
        }
        catch (JsonException)
        {
        }
        
        try
        {
            return JsonSerializer.Deserialize<T2>(ref reader)!;
        }
        catch (JsonException)
        {
        }
        
        return new AnyOf<T1, T2>();
    }

    public override void Write(
        Utf8JsonWriter writer,
        AnyOf<T1, T2> anyOf,
        JsonSerializerOptions options)
    {
        if (anyOf.IsFirst)
        {
            JsonSerializer.Serialize(writer, anyOf.First, anyOf.First!.GetType(), options);
        }
        else if (anyOf.IsSecond)
        {
            JsonSerializer.Serialize(writer, anyOf.Second, anyOf.Second!.GetType(), options);
        }
        else
        {
            writer.WriteStringValue("null");
        }
    }
}