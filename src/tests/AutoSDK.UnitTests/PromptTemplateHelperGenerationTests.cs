using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PromptTemplateHelperGenerationTests
{
    [TestMethod]
    public void PromptTemplateHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Prompts",
        };

        var file = Sources.PromptTemplateHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void PromptTemplateHelpers_WithCustomClassName_GeneratesConfiguredManager()
    {
        var settings = Settings.Default with
        {
            Namespace = "Prompts",
            GeneratePromptTemplateHelpers = true,
            PromptTemplateHelperClassName = "ProviderPromptManager",
        };

        var file = Sources.PromptTemplateHelpers(settings);

        file.Name.Should().Be("Prompts.ProviderPromptManager.g.cs");
        file.Text.Should().Contain("public sealed class ProviderPromptManager");
        file.Text.Should().Contain("public sealed class AutoSDKPromptTemplate");
        file.Text.Should().Contain("public sealed class AutoSDKPromptTemplateMessage");
        file.Text.Should().Contain("RenderStringAsync(");
        file.Text.Should().Contain("RenderMessagesAsync(");
        file.Text.Should().Contain("AutoSDKPromptTemplateRenderException");
        file.Text.Should().Contain("global::System.Collections.Generic.Dictionary<string, CacheEntry>");
        file.Text.Should().Contain("template.IndexOf(\"{{\"");
        file.Text.Should().Contain("template.IndexOf(\"}}\"");
    }
}
