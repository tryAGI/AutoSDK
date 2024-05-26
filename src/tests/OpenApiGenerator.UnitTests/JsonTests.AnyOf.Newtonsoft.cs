using Newtonsoft.Json;
using AnyOfTypes;
using OpenApiGenerator.JsonConverters;

namespace OpenApiGenerator.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void AnyOf_First_NewtonsoftJson()
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
    public void AnyOf_Second_NewtonsoftJson()
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
    public void AnyOf_Undefined_NewtonsoftJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>();

        var serialization = () => JsonConvert.SerializeObject(value, new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        serialization.Should().Throw<JsonException>();

        var deserialization = () => JsonConvert.DeserializeObject<AnyOf<PullModelResponse2, PullModelResponse>>("\"null\"", new JsonSerializerSettings
        {
            Converters = { new AnyOfConverterNewtonsoftJson<PullModelResponse2, PullModelResponse>() }
        });
        deserialization.Should().Throw<JsonException>();
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid1_NewtonsoftJson()
    {
        const string json = "{\n  \"age\": 1\n}";
        var response = JsonConvert.DeserializeObject<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerSettings
        {
            Converters = {
                new AnyOfConverterNewtonsoftJson<PetByAge, PetByType>(),
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
    public void AnyOf_OfficialExample_Valid2_NewtonsoftJson()
    {
        const string json = "{\n  \"pet_type\": \"Cat\",\n  \"hunts\": true\n}";
        var response = JsonConvert.DeserializeObject<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerSettings
        {
            Converters = {
                new AnyOfConverterNewtonsoftJson<PetByAge, PetByType>(),
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
    public void AnyOf_OfficialExample_Valid3_NewtonsoftJson()
    {
        const string json = "{\n  \"nickname\": \"Fido\",\n  \"pet_type\": \"Dog\",\n  \"age\": 4\n}";
        var response = JsonConvert.DeserializeObject<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerSettings
        {
            Converters = {
                new AnyOfConverterNewtonsoftJson<PetByAge, PetByType>(),
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
    public void AnyOf_OfficialExample_NotValid1_NewtonsoftJson()
    {
        const string json = "{\n  \"nickname\": \"Mr. Paws\",\n  \"hunts\": false\n}";
        var deserialization = () => JsonConvert.DeserializeObject<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerSettings
        {
            Converters = {
                new AnyOfConverterNewtonsoftJson<PetByAge, PetByType>(),
            }
        });
        deserialization.Should().Throw<JsonException>();
    }
}