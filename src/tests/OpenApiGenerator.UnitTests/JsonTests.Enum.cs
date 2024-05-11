using System.Text.Json;

namespace OpenApiGenerator.UnitTests;

[TestClass]
public class JsonTests
{
    [TestMethod]
    public void Enum_SystemTextJson()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        Assert.ThrowsException<JsonException>(() => JsonSerializer.Deserialize<PullModelResponse>(json));
    }
    
    [TestMethod]
    public void Enum_NewtonsoftJson()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<PullModelResponse>(json);
        response.Should().NotBeNull();
        response!.Status.Should().Be(PullModelResponseStatus.PullingManifest);
    }
    
    [TestMethod]
    public void EnumAsString_SystemTextJson()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        var response = JsonSerializer.Deserialize<PullModelResponse2>(json);
        response.Should().NotBeNull();
        response!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
    }
    
    [TestMethod]
    public void EnumAsString_NewtonsoftJson()
    {
        const string json = "{\n  \"status\": \"pulling manifest\"\n}";

        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<PullModelResponse2>(json);
        response.Should().NotBeNull();
        response!.Status.Should().Be(PullModelResponseStatus2.PullingManifest);
    }
}

public sealed partial class PullModelResponse
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    public PullModelResponseStatus? Status { get; set; }
}

[global::System.Runtime.Serialization.DataContract]
public enum PullModelResponseStatus
{
    [global::System.Runtime.Serialization.EnumMember(Value="pulling manifest")]
    PullingManifest,
    
    [global::System.Runtime.Serialization.EnumMember(Value="success")]
    Success,
}

public sealed partial class PullModelResponse2
{
    [global::System.Text.Json.Serialization.JsonPropertyName("status")]
    public string? Status { get; set; }
}

public abstract class PullModelResponseStatus2
{
    public const string PullingManifest = "pulling manifest";
    public const string Success = "success";
}