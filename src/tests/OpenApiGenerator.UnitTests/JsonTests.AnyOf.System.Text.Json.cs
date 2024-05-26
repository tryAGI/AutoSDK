using System.Text.Json;
using AnyOfTypes;
using OpenApiGenerator.JsonConverters;
using JsonException = System.Text.Json.JsonException;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void AnyOf_First_SystemTextJson()
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
    public void AnyOf_Second_SystemTextJson()
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
    public void AnyOf_Undefined_SystemTextJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>();

        var serialization = () => JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterSystemTextJson<PullModelResponse2, PullModelResponse>() }
        });
        serialization.Should().Throw<JsonException>();
        
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>("\"null\"", new JsonSerializerOptions
        {
            Converters = {
                new AnyOfConverterSystemTextJson<PetByAge, PetByType>(),
            }
        });
        deserialization.Should().Throw<JsonException>();
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid1_SystemTextJson()
    {
        const string json = "{\n  \"age\": 1\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = {
                new AnyOfConverterSystemTextJson<PetByAge, PetByType>(),
            }
        });
        response.Should().NotBeNull();
        response.IsFirst.Should().BeTrue();
        response.First.Should().NotBeNull();
        response.First!.age.Should().Be(1);
        response.IsSecond.Should().BeFalse();
        response.Second.Should().BeNull();
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid2_SystemTextJson()
    {
        const string json = "{\n  \"pet_type\": \"Cat\",\n  \"hunts\": true\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = {
                new AnyOfConverterSystemTextJson<PetByAge, PetByType>(),
            }
        });
        response.Should().NotBeNull();
        response.IsFirst.Should().BeFalse();
        response.First.Should().BeNull();
        response.IsSecond.Should().BeTrue();
        response.Second.Should().NotBeNull();
        response.Second!.hunts.Should().BeTrue();
        response.Second!.pet_type.Should().Be("Cat");
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid3_SystemTextJson()
    {
        const string json = "{\n  \"nickname\": \"Fido\",\n  \"pet_type\": \"Dog\",\n  \"age\": 4\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = {
                new AnyOfConverterSystemTextJson<PetByAge, PetByType>(),
            }
        });
        response.Should().NotBeNull();
        response.IsFirst.Should().BeTrue();
        response.First.Should().NotBeNull();
        response.First!.nickname.Should().Be("Fido");
        response.First!.age.Should().Be(4);
        response.IsSecond.Should().BeTrue();
        response.Second.Should().NotBeNull();
        response.Second!.hunts.Should().BeNull();
        response.Second!.pet_type.Should().Be("Dog");
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_NotValid1_SystemTextJson()
    {
        const string json = "{\n  \"nickname\": \"Mr. Paws\",\n  \"hunts\": false\n}";
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = {
                new AnyOfConverterSystemTextJson<PetByAge, PetByType>(),
            }
        });
        deserialization.Should().Throw<JsonException>();
    }
}

public class PetByAge
{
    [Newtonsoft.Json.JsonRequired]
    public required int age { get; set; }
    public string? nickname { get; set; }
}

public class PetByType
{
    [Newtonsoft.Json.JsonRequired]
    public required string pet_type { get; set; }
    public bool? hunts { get; set; }
}