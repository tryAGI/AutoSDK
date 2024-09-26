using System.Text.Json;
using AutoSDK.JsonConverters;
using JsonException = System.Text.Json.JsonException;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AutoSDK.UnitTests;

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
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        json.Should().Be("{\"status\":\"pulling manifest\"}");
        
        json = JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            TypeInfoResolver = TestSourceGenerationContext.Default,
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        json.Should().Be("{\"status\":\"pulling manifest\"}");
        
        json = JsonSerializer.Serialize(value, TestSourceGenerationContext.Default.AnyOfPullModelResponse2PullModelResponse);
        json.Should().Be("{\"status\":\"pulling manifest\"}");

        var response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.Value1.Should().NotBeNull();
        response.Value1!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
        
        response.Match(
            value1: v => v.Status.Should().Be(PullModelResponseStatus2.PullingManifest),
            value2: _ => Assert.Fail("Should not be here"),
            validate: true);
        
        response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            TypeInfoResolver = TestSourceGenerationContext.Default,
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.Value1.Should().NotBeNull();
        response.Value1!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
        
        response.Match(
            value1: v => v.Status.Should().Be(PullModelResponseStatus2.PullingManifest),
            value2: _ => Assert.Fail("Should not be here"),
            validate: true);
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
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        json.Should().Be("{\"status\":0}");
        var response = JsonSerializer.Deserialize<AnyOf<PullModelResponse2, PullModelResponse>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.Value2.Should().NotBeNull();
        response.Value2!.Status.Should().Be(PullModelResponseStatus.PullingManifest);
    }
    
    [TestMethod]
    public void AnyOf_Undefined_SystemTextJson()
    {
        var value = new AnyOf<PullModelResponse2, PullModelResponse>();

        var serialization = () => JsonSerializer.Serialize(value, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        serialization.Should().Throw<JsonException>();
        
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>("\"null\"", new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        deserialization.Should().Throw<JsonException>();
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid1_SystemTextJson()
    {
        const string json = "{\n  \"age\": 1\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.IsValue1.Should().BeTrue();
        response.Value1.Should().NotBeNull();
        response.Value1!.age.Should().Be(1);
        response.IsValue2.Should().BeFalse();
        response.Value2.Should().BeNull();
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid2_SystemTextJson()
    {
        const string json = "{\n  \"pet_type\": \"Cat\",\n  \"hunts\": true\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.IsValue1.Should().BeFalse();
        response.Value1.Should().BeNull();
        response.IsValue2.Should().BeTrue();
        response.Value2.Should().NotBeNull();
        response.Value2!.hunts.Should().BeTrue();
        response.Value2!.pet_type.Should().Be("Cat");
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_Valid3_SystemTextJson()
    {
        const string json = "{\n  \"nickname\": \"Fido\",\n  \"pet_type\": \"Dog\",\n  \"age\": 4\n}";
        var response = JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
        });
        response.Should().NotBeNull();
        response.IsValue1.Should().BeTrue();
        response.Value1.Should().NotBeNull();
        response.Value1!.nickname.Should().Be("Fido");
        response.Value1!.age.Should().Be(4);
        response.IsValue2.Should().BeTrue();
        response.Value2.Should().NotBeNull();
        response.Value2!.hunts.Should().BeNull();
        response.Value2!.pet_type.Should().Be("Dog");
    }
    
    [TestMethod]
    public void AnyOf_OfficialExample_NotValid1_SystemTextJson()
    {
        const string json = "{\n  \"nickname\": \"Mr. Paws\",\n  \"hunts\": false\n}";
        var deserialization = () => JsonSerializer.Deserialize<AnyOf<PetByAge, PetByType>>(json, new JsonSerializerOptions
        {
            Converters = { new AnyOfConverterFactorySystemTextJson() }
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