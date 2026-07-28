using AutoSDK.Generation;
using AutoSDK.Models;
using AutoSDK.Serialization.Json;
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

    private static PreparedData Prepare(string specificationName)
    {
        var settings = CanarySettings;
        return AutoSDK.Generation.Data.Prepare(
            ((TestSpecCache.GetText(specificationName), settings), GlobalSettings: settings));
    }
}
