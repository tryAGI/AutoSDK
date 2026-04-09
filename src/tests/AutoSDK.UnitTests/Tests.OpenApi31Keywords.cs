using AutoSDK.Extensions;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class OpenApi31KeywordTests
{
    [TestMethod]
    public void NormalizesRepresentativeOpenApi31Keywords()
    {
        var json = TestSpecCache.GetText("openapi31-keyword-normalization.json");

        var document = json.GetOpenApiDocument(Settings.Default);
        document.Components.Should().NotBeNull();
        document.Components!.Schemas.Should().ContainKey("Payload");
        var payload = document.Components.Schemas["Payload"];
        var properties = payload.Properties!;

        document.JsonSchemaDialect?.ToString().Should().Be("https://json-schema.org/draft/2020-12/schema");
        payload.AdditionalPropertiesAllowed.Should().BeFalse();
        payload.Extensions.Should().ContainKey("x-autosdk-json-schema-propertyNames");
        payload.Extensions.Should().ContainKey("x-autosdk-json-schema-dependentRequired");
        payload.Extensions.Should().ContainKey("x-autosdk-json-schema-dependentSchemas");

        properties["blob"].IsBase64().Should().BeTrue();
        properties["blob"].Extensions.Should().ContainKey("x-autosdk-json-schema-contentEncoding");

        properties["file"].IsBinary().Should().BeTrue();
        properties["file"].Extensions.Should().ContainKey("x-autosdk-json-schema-contentMediaType");

        properties["csv"].Extensions.Should().ContainKey("x-autosdk-json-schema-contentMediaType");
        properties["json_payload"].Extensions.Should().ContainKey("x-autosdk-json-schema-contentSchema");

        var pair = properties["pair"];
        pair.MaxItems.Should().Be(2);
        pair.Extensions.Should().ContainKey("x-autosdk-json-schema-unevaluatedItems");
        pair.Items.Should().NotBeNull();
        pair.Items!.AnyOf.Should().HaveCount(2);
    }

    [TestMethod]
    public void RejectsStillUnsupportedOpenApi31KeywordsWithClearPaths()
    {
        var json = TestSpecCache.GetText("openapi31-keyword-unsupported.json");

        Action action = () => _ = json.GetOpenApiDocument(Settings.Default);

        var exception = action.Should().Throw<AggregateException>().Which;
        var messages = exception.InnerExceptions.Select(static x => x.Message).ToArray();

        messages.Should().Contain(message =>
            message.Contains("patternProperties", StringComparison.Ordinal) &&
            message.Contains("#/components/schemas/RegexMap", StringComparison.Ordinal));
        messages.Should().Contain(message =>
            message.Contains("contains", StringComparison.Ordinal) &&
            message.Contains("#/components/schemas/FilteredArray", StringComparison.Ordinal));
    }
}
