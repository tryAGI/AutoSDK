using System.Text.Json;
using System.Text.Json.Serialization;
using AutoSDK.JsonConverters;
using JsonSerializer = System.Text.Json.JsonSerializer;
using AutoSDK.UnitTests.OneOfDiscriminatorConst;

namespace AutoSDK.UnitTests;

public partial class JsonTests
{
    private readonly JsonSerializerOptions _invocationSystemTextJsonOptions = new()
    {
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Converters =
        {
            new InvocationConverterSystemTextJson(),
        }
    };

    [TestMethod]
    public void AnyOf_SystemTextJson_DiscriminatorConst_Succeeded()
    {
        var response = JsonSerializer.Deserialize<AnyOf<InvocationPending, InvocationSucceeded>>(/*language=json*/
            """
            {
              "id": "abc",
              "status": "SUCCEEDED",
              "output": "https://example.com/file.png"
            }
            """, _invocationSystemTextJsonOptions);

        response.Should().NotBeNull();
        response!.IsValue1.Should().BeFalse();
        response.IsValue2.Should().BeTrue();
        response.Value2!.status.Should().Be("SUCCEEDED");
        response.Value2!.output.Should().Be("https://example.com/file.png");
    }

    [TestMethod]
    public void AnyOf_SystemTextJson_DiscriminatorConst_Pending()
    {
        var response = JsonSerializer.Deserialize<AnyOf<InvocationPending, InvocationSucceeded>>(/*language=json*/
            """
            {
              "id": "abc",
              "status": "PENDING"
            }
            """, _invocationSystemTextJsonOptions);

        response.Should().NotBeNull();
        response!.IsValue1.Should().BeTrue();
        response.IsValue2.Should().BeFalse();
        response.Value1!.status.Should().Be("PENDING");
    }
}

public class InvocationDiscriminator
{
    [System.Text.Json.Serialization.JsonPropertyName("status")]
    public string? Status { get; set; }
}

public class InvocationConverterSystemTextJson : global::System.Text.Json.Serialization.JsonConverter<AnyOf<InvocationPending, InvocationSucceeded>>
{
    public override AnyOf<InvocationPending, InvocationSucceeded> Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        options = options ?? throw new global::System.ArgumentNullException(nameof(options));

        var readerCopy = reader;
        var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<InvocationDiscriminator>(ref readerCopy, options);

        InvocationPending? value1 = default;
        if (discriminator?.Status == "PENDING")
        {
            value1 = global::System.Text.Json.JsonSerializer.Deserialize<InvocationPending>(ref reader, options);
        }

        InvocationSucceeded? value2 = default;
        if (discriminator?.Status == "SUCCEEDED")
        {
            value2 = global::System.Text.Json.JsonSerializer.Deserialize<InvocationSucceeded>(ref reader, options);
        }

        return new AnyOf<InvocationPending, InvocationSucceeded>(value1, value2);
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        AnyOf<InvocationPending, InvocationSucceeded> value,
        global::System.Text.Json.JsonSerializerOptions options)
    {
        options = options ?? throw new global::System.ArgumentNullException(nameof(options));

        if (value.IsValue1)
        {
            global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeof(InvocationPending), options);
        }
        else if (value.IsValue2)
        {
            global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeof(InvocationSucceeded), options);
        }
    }
}
