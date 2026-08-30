using AutoSDK.Extensions;
using AutoSDK.Models;
using System.Text.Json.Nodes;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;

namespace AutoSDK.UnitTests;

[TestClass]
public class OpenApi31KeywordTests
{
    [TestMethod]
    public void MicrosoftOpenApi310RetainsNativeKeywordsButStillDropsTupleKeywords()
    {
        var json = TestSpecCache.GetText("openapi31-keyword-normalization.json");
        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };

        var result = new OpenApiJsonReader().Read(
            JsonNode.Parse(json)!,
            new Uri("https://openapi.net/"),
            readerSettings);
        var payload = (OpenApiSchema)result.Document!.Components!.Schemas!["Payload"];
        var properties = payload.Properties!;

        result.Diagnostic!.Errors.Should().BeEmpty();
        payload.PropertyNames.Should().NotBeNull();
        payload.DependentRequired.Should().ContainKey("blob");
        payload.DependentSchemas.Should().ContainKey("json_payload");
        payload.UnevaluatedProperties.Should().BeFalse();
        ((OpenApiSchema)properties["blob"]).ContentEncoding.Should().Be("base64");

        var pair = (OpenApiSchema)properties["pair"];
        pair.Items.Should().BeNull();
        pair.MaxItems.Should().BeNull();
    }

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

    [TestMethod]
    public void NormalizesBooleanItemsWithoutAnotherCompatibilityKeyword()
    {
        const string json = """
        {
          "openapi": "3.1.0",
          "info": { "title": "ClosedArray", "version": "1.0.0" },
          "paths": {},
          "components": {
            "schemas": {
              "ClosedArray": {
                "type": "array",
                "items": false
              }
            }
          }
        }
        """;

        var document = json.GetOpenApiDocument(Settings.Default);
        var schema = document.Components!.Schemas!["ClosedArray"];

        schema.Items.Should().BeNull();
        schema.MaxItems.Should().Be(0);
    }
}
