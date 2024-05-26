using Newtonsoft.Json;
using AnyOfTypes;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void AnyOf2_First_NewtonsoftJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>(new PullModelResponse2
        {
            Status = PullModelResponseStatus2.PullingManifest,
        });

        var json = JsonConvert.SerializeObject(value, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("{\"Status\":\"pulling manifest\"}");
        var response = JsonConvert.DeserializeObject<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        response.First.Should().NotBeNull();
        response.First!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
    }
    
    [TestMethod]
    public void AnyOf2_Second_NewtonsoftJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>(new PullModelResponse
        {
            Status = PullModelResponseStatus.PullingManifest,
        });

        var json = JsonConvert.SerializeObject(value, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("{\"Status\":0}");
        var response = JsonConvert.DeserializeObject<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        //response.Second.Should().NotBeNull();
        //response.Second!.Status.Should().Be(PullModelResponseStatus.PullingManifest);
    }
    
    [TestMethod]
    public void AnyOf2_Undefined_NewtonsoftJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>();

        var json = JsonConvert.SerializeObject(value, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        json.Should().Be("\"null\"");
        var response = JsonConvert.DeserializeObject<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        response.Should().NotBeNull();
        response.IsUndefined.Should().BeTrue();
    }
}

public class AnyOfConverterNewtonsoftJson<T1, T2> : JsonConverter<AnyOf<T1, T2>>
{
    public override void WriteJson(JsonWriter writer, AnyOf<T1, T2> value, JsonSerializer serializer)
    {
        if (value.IsFirst)
        {
            serializer.Serialize(writer, value.First, value.First!.GetType());
        }
        else if (value.IsSecond)
        {
            serializer.Serialize(writer, value.Second, value.Second!.GetType());
        }
        else
        {
            writer.WriteValue("null");
        }
    }

    public override AnyOf<T1, T2> ReadJson(JsonReader reader, Type objectType, AnyOf<T1, T2> existingValue, bool hasExistingValue,
        JsonSerializer serializer)
    {
        try
        {
            return serializer.Deserialize<T1>(reader)!;
        }
        catch (JsonException)
        {
        }
        
        try
        {
            return serializer.Deserialize<T2>(reader)!;
        }
        catch (JsonException)
        {
        }
        
        return new AnyOf<T1, T2>();
    }
}