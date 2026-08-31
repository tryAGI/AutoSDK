using AutoSDK.Extensions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using System.Text.Json.Nodes;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class OpenApiSchemaExtensionsTests
{
    [TestMethod]
    public void IsNullableAnyOf_RequiresExactlyOneNullVariant()
    {
        var nullable = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        var twoNulls = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.Null },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        var twoValues = new OpenApiSchema
        {
            AnyOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Integer },
            ],
        };

        nullable.IsNullableAnyOf().Should().BeTrue();
        twoNulls.IsNullableAnyOf().Should().BeFalse();
        twoValues.IsNullableAnyOf().Should().BeFalse();
    }

    [TestMethod]
    public void IsNullableOneOf_RequiresExactlyOneNullVariant()
    {
        var nullable = new OpenApiSchema
        {
            OneOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.Null },
                new OpenApiSchema { Type = JsonSchemaType.Object },
            ],
        };
        var twoNulls = new OpenApiSchema
        {
            OneOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.Null },
                new OpenApiSchema { Type = JsonSchemaType.Null },
            ],
        };
        var twoValues = new OpenApiSchema
        {
            OneOf =
            [
                new OpenApiSchema { Type = JsonSchemaType.String },
                new OpenApiSchema { Type = JsonSchemaType.Integer },
            ],
        };

        nullable.IsNullableOneOf().Should().BeTrue();
        nullable.IsNullableAnyOfLike().Should().BeTrue();
        nullable.IsOneOf().Should().BeFalse();
        twoNulls.IsNullableOneOf().Should().BeFalse();
        twoValues.IsNullableOneOf().Should().BeFalse();
        twoValues.IsOneOf().Should().BeTrue();
    }

    [TestMethod]
    public void AnyOfOneOfAndAllOf_RequireNonEmptyVariants()
    {
        var anyOf = new OpenApiSchema { AnyOf = [new OpenApiSchema()] };
        var oneOf = new OpenApiSchema { OneOf = [new OpenApiSchema()] };
        var allOf = new OpenApiSchema { AllOf = [new OpenApiSchema()] };
        var empty = new OpenApiSchema();

        anyOf.IsAnyOf().Should().BeTrue();
        oneOf.IsOneOf().Should().BeTrue();
        allOf.IsAllOf().Should().BeTrue();
        empty.IsAnyOf().Should().BeFalse();
        empty.IsOneOf().Should().BeFalse();
        empty.IsAllOf().Should().BeFalse();
    }

    [TestMethod]
    public void IsUnixTimestamp_DoesNotClassifyMillisecondIntegers()
    {
        var seconds = new OpenApiSchema
        {
            Type = JsonSchemaType.Integer,
            Format = "int64",
            Description = "The Unix timestamp in seconds.",
        };
        var milliseconds = new OpenApiSchema
        {
            Type = JsonSchemaType.Integer,
            Format = "int64",
            Description = "Start of the time range as a Unix timestamp in milliseconds.",
        };

        seconds.IsUnixTimestamp().Should().BeTrue();
        milliseconds.IsUnixTimestamp().Should().BeFalse();
    }

    [TestMethod]
    public void ResolveBareReference_UsesResolvedTarget()
    {
        var reference = ParseSchemaReference("""
            "value": { "$ref": "#/components/schemas/Target" }
            """);

        var resolved = reference.ResolveBareReference();

        resolved.Should().NotBeSameAs(reference);
        resolved.Description.Should().Be("target description");
    }

    [TestMethod]
    public void ResolveBareReference_PreservesSiblingOverrides()
    {
        var reference = ParseSchemaReference("""
            "value": {
              "$ref": "#/components/schemas/Target",
              "description": "sibling description"
            }
            """);

        var resolved = reference.ResolveBareReference();

        resolved.Should().BeSameAs(reference);
        resolved.Description.Should().Be("sibling description");
    }

    private static IOpenApiSchema ParseSchemaReference(string propertyJson)
    {
        var json = $$"""
            {
              "openapi": "3.1.0",
              "info": { "title": "Reference", "version": "1.0.0" },
              "paths": {},
              "components": {
                "schemas": {
                  "Target": {
                    "type": "string",
                    "description": "target description"
                  },
                  "Container": {
                    "type": "object",
                    "properties": { {{propertyJson}} }
                  }
                }
              }
            }
            """;
        var settings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        var result = new OpenApiJsonReader().Read(
            JsonNode.Parse(json)!,
            new Uri("https://openapi.net/"),
            settings);

        return result.Document!.Components!.Schemas!["Container"].Properties!["value"];
    }
}
