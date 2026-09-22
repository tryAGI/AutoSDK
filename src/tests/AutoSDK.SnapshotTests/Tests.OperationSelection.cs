using AutoSDK.SourceGenerators;
using H.Generators.Tests.Extensions;

namespace AutoSDK.SnapshotTests;

public partial class Tests
{
    [TestMethod]
    public void GetSettings_ParsesOperationProfileSelectors()
    {
        var settings = new DictionaryAnalyzerConfigOptionsProvider(new Dictionary<string, string>
        {
            ["build_property.AutoSDK_IncludePaths"] = "/alpha;/beta",
            ["build_property.AutoSDK_ExcludePaths"] = "/beta",
            ["build_property.AutoSDK_IncludeOperationIds"] = "listAlpha;createAlpha",
            ["build_property.AutoSDK_ExcludeOperationIds"] = "createAlpha",
            ["build_property.AutoSDK_IncludeTags"] = "alpha;shared",
            ["build_property.AutoSDK_ExcludeTags"] = "legacy",
        }).GetSettings(prefix: "AutoSDK");

        settings.IncludePaths.Should().Equal("/alpha", "/beta");
        settings.ExcludePaths.Should().Equal("/beta");
        settings.IncludeOperationIds.Should().Equal("listAlpha", "createAlpha");
        settings.ExcludeOperationIds.Should().Equal("createAlpha");
        settings.IncludeTags.Should().Equal("alpha", "shared");
        settings.ExcludeTags.Should().Equal("legacy");
    }
}
