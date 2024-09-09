using System.Text.Json;
using AutoSDK.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    [TestMethod]
    public void UnixTimestamp_SystemTextJson()
    {
        var testValue = DateTimeOffset.FromUnixTimeSeconds(1693382400);
        
        var json = JsonSerializer.Serialize(testValue, new JsonSerializerOptions
        {
            Converters = { new UnixTimestampJsonConverterSystemTextJson() }
        });
        json.Should().Be($"{testValue.ToUnixTimeSeconds()}");
        
        json = JsonSerializer.Serialize(testValue, new JsonSerializerOptions
        {
            TypeInfoResolver = TestSourceGenerationContext.Default,
            Converters = { new UnixTimestampJsonConverterSystemTextJson() }
        });
        json.Should().Be($"{testValue.ToUnixTimeSeconds()}");
        
        json = JsonSerializer.Serialize(testValue, TestSourceGenerationContext.Default.DateTimeOffset);
        json.Should().Be($"{testValue.ToUnixTimeSeconds()}");

        var response = JsonSerializer.Deserialize<DateTimeOffset>(json, new JsonSerializerOptions
        {
            Converters = { new UnixTimestampJsonConverterSystemTextJson() }
        });
        response.Should().Be(testValue);
        
        response = JsonSerializer.Deserialize<DateTimeOffset>(json, new JsonSerializerOptions
        {
            TypeInfoResolver = TestSourceGenerationContext.Default,
            Converters = { new UnixTimestampJsonConverterSystemTextJson() }
        });
        response.Should().Be(testValue);
        
        response = JsonSerializer.Deserialize(json, TestSourceGenerationContext.Default.DateTimeOffset);
        response.Should().Be(testValue);
    }
    
    [TestMethod]
    public void UnixTimestamp_NewtonsoftJson()
    {
        var testValue = DateTimeOffset.FromUnixTimeSeconds(1693382400);
        
        var json = Newtonsoft.Json.JsonConvert.SerializeObject(testValue, new UnixTimestampJsonConverterNewtonsoftJson());
        json.Should().Be($"{testValue.ToUnixTimeSeconds()}");
        
        var response = Newtonsoft.Json.JsonConvert.DeserializeObject<DateTimeOffset>(json, new UnixTimestampJsonConverterNewtonsoftJson());
        response.Should().Be(testValue);
    }
}