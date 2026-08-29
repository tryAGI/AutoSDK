using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
using Microsoft.OpenApi;
using PreparedData = AutoSDK.Models.Data;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class OpenApiUpgradeCanaryTests
{
    private static Settings CanarySettings => Settings.Default with
    {
        GenerateMethods = true,
        GenerateModels = true,
        GenerateSdk = true,
        JsonSerializerType = JsonSerializerType.SystemTextJson,
        Namespace = "G",
        ClassName = "Api",
        TargetFramework = "net8.0",
    };

    [TestMethod]
    [TestCategory("OpenApiUpgradeCanary")]
    public void Qdrant_GeneratedTypeIdentitiesRemainStable()
    {
        var data = Prepare("qdrant.json");
        var classNames = data.Classes.Select(x => x.ClassName).ToArray();
        var anyOfNames = data.AnyOfs.Select(x => x.Name).ToArray();

        classNames.Should().ContainSingle(x => x == "Filter");
        classNames.Should().NotContain("Filter2");
        anyOfNames.Should().ContainSingle(x => x == "Query");
        anyOfNames.Should().NotContain(["Query2", "Query3"]);
    }

    [TestMethod]
    [TestCategory("OpenApiUpgradeCanary")]
    public void GitHub_MetadataPropertyTypeIdentityRemainsStable()
    {
        var data = Prepare("github.yaml");
        var dependency = data.Classes.Single(x => x.ClassName == "Dependency");
        var generatedDependency = Sources.GenerateModel(dependency);

        generatedDependency.Should()
            .Contain("Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? Metadata");
        generatedDependency.Should().NotContain("global::G.Metadata? Metadata");
    }

    [TestMethod]
    [TestCategory("OpenApiUpgradeCanary")]
    public void OpenApi30_LegacyNullAndPrimitiveUnionShapesRemainStable()
    {
        const string specification = """
openapi: 3.0.3
info:
  title: Compatibility canary
  version: 1.0.0
paths: {}
components:
  schemas:
    Choice:
      oneOf:
        - type: object
        - type: string
    NullEnum:
      enum:
        - null
""";

        var document = specification.GetOpenApiDocument(CanarySettings);
        var choice = document.Components!.Schemas!["Choice"];
        var nullEnum = document.Components.Schemas["NullEnum"];

        choice.OneOf.Should().HaveCount(2);
        choice.OneOf![0].Type.Should().Be(JsonSchemaType.Object);
        choice.OneOf[1].Type.Should().Be(JsonSchemaType.String);
        nullEnum.Type.Should().BeNull();
        nullEnum.Enum.Should().ContainSingle(x => x.IsJsonNullSentinel());
    }

    [TestMethod]
    [TestCategory("OpenApiUpgradeCanary")]
    public void OpenApi31_LegacyNullableKeywordUsesTypeArraySemantics()
    {
        const string specification = """
{
  "openapi": "3.1.0",
  "info": { "title": "Compatibility canary", "version": "1.0.0" },
  "paths": {},
  "components": {
    "schemas": {
      "NullableText": { "type": "string", "nullable": true }
    }
  }
}
""";

        var document = specification.GetOpenApiDocument(CanarySettings);
        var nullableText = document.Components!.Schemas!["NullableText"];

        nullableText.Type.Should().Be(JsonSchemaType.String | JsonSchemaType.Null);
    }

    private static PreparedData Prepare(string specificationName)
    {
        var settings = CanarySettings;
        return AutoSDK.Generation.Data.Prepare(
            ((TestSpecCache.GetText(specificationName), settings), GlobalSettings: settings));
    }
}
