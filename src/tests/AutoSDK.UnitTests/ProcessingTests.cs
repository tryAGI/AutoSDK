using System.Text.Json.Nodes;
using AutoSDK.Extensions;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Reader;
using Microsoft.OpenApi.YamlReader;

namespace AutoSDK.UnitTests;

[TestClass]
public class ProcessingTests : VerifyBase
{
    [TestMethod]
    public void ComputeDiscriminators_ProcessesComponentRootAfterDeepReference()
    {
        JsonNode deepReference = new JsonObject
        {
            ["$ref"] = "#/components/schemas/ZRoot",
        };
        for (var depth = 0; depth < 10; depth++)
        {
            deepReference = new JsonObject
            {
                ["type"] = "object",
                ["properties"] = new JsonObject
                {
                    ["next"] = deepReference,
                },
            };
        }

        var document = ParseJsonDocument(new JsonObject
        {
            ["AEntry"] = deepReference,
            ["ZRoot"] = new JsonObject
            {
                ["type"] = "object",
                ["properties"] = new JsonObject
                {
                    ["payload"] = CreateDiscriminatedSchemaJson(),
                },
            },
        });

        document.ComputeDiscriminators();

        var rootSchema = document.Components!.Schemas!["ZRoot"].ResolveSchema();
        var discriminatedSchema = rootSchema!.Properties!["payload"].ResolveSchema();
        discriminatedSchema!.Discriminator.Should().NotBeNull();
        discriminatedSchema.Discriminator!.PropertyName.Should().Be("kind");
    }

    [TestMethod]
    public void ComputeDiscriminators_ProcessesReferenceSiblingCompositionAfterTarget()
    {
        var siblingComposition = CreateDiscriminatedSchemaJson();
        var document = ParseJsonDocument(new JsonObject
        {
            ["ABase"] = new JsonObject
            {
                ["type"] = "object",
            },
            ["ZWrapper"] = new JsonObject
            {
                ["type"] = "object",
                ["properties"] = new JsonObject
                {
                    ["choice"] = new JsonObject
                    {
                        ["$ref"] = "#/components/schemas/ABase",
                        ["oneOf"] = siblingComposition["oneOf"]!.DeepClone(),
                    },
                },
            },
        });

        document.ComputeDiscriminators();

        var baseSchema = document.Components!.Schemas!["ABase"].ResolveSchema();
        baseSchema!.Discriminator.Should().NotBeNull();
        baseSchema.Discriminator!.PropertyName.Should().Be("kind");
    }

    [TestMethod]
    [DataRow("openai.yaml")]
    [DataRow("cohere.yaml")]
    public async Task ComputeDiscriminators(string resourceName)
    {
        var yamlOrJson = TestSpecCache.GetText(resourceName);

        var readerSettings = new OpenApiReaderSettings
        {
            RuleSet = ValidationRuleSet.GetEmptyRuleSet(),
        };
        readerSettings.AddYamlReader();

        var (document, diagnostics) = OpenApiDocument.Parse(yamlOrJson, settings: readerSettings);
        if (document == null)
        {
            throw new InvalidOperationException("Document is null");
        }
        
        document = document.ComputeDiscriminators();
        
        yamlOrJson = await document.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);
        
        await Task.WhenAll(
            Verify(diagnostics?.Errors ?? [])
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("Errors"),
            Verify(diagnostics?.Warnings ?? [])
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .AutoVerify()
                .UseTextForParameters("Warnings"),
            Verify(yamlOrJson)
                .UseDirectory($"Snapshots/Processing/DetectedDiscriminators/{resourceName}")
                .UseFileName("_")
                .AutoVerify()
        );
    }

    private static OpenApiDocument ParseJsonDocument(JsonObject schemas)
    {
        var json = new JsonObject
        {
            ["openapi"] = "3.1.0",
            ["info"] = new JsonObject
            {
                ["title"] = "Discriminator regression",
                ["version"] = "1.0.0",
            },
            ["paths"] = new JsonObject(),
            ["components"] = new JsonObject
            {
                ["schemas"] = schemas,
            },
        };

        var (document, diagnostics) = OpenApiDocument.Parse(json.ToJsonString());
        diagnostics?.Errors.Should().BeEmpty();
        document.Should().NotBeNull();
        return document!;
    }

    private static JsonObject CreateDiscriminatedSchemaJson()
    {
        return new JsonObject
        {
            ["oneOf"] = new JsonArray(
                CreateDiscriminatorVariantJson("alpha"),
                CreateDiscriminatorVariantJson("beta")),
        };
    }

    private static JsonObject CreateDiscriminatorVariantJson(string value)
    {
        return new JsonObject
        {
            ["type"] = "object",
            ["properties"] = new JsonObject
            {
                ["kind"] = new JsonObject
                {
                    ["type"] = "string",
                    ["enum"] = new JsonArray(value),
                },
            },
        };
    }
}
