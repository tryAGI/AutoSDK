using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PageableNextUrlTests
{
    [TestMethod]
    public void NextUrlAsync_EmittedWhenPageableHelpersEnabled()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePageableHelpers = true,
        };

        var source = Sources.GeneratePageableHelpers(settings);

        source.Should().Contain("public static async global::System.Collections.Generic.IAsyncEnumerable<TItem> NextUrlAsync<TPage, TItem>(");
        source.Should().Contain("Refusing to follow next-page URL");
        source.Should().Contain("EnsureSameOrigin(url!, baseAddress);");
        source.Should().Contain("public static void EnsureSameOrigin(string nextUrl, global::System.Uri? baseAddress)");
    }

    [TestMethod]
    public void NextUrlAsync_OmittedWhenPageableHelpersDisabled()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GeneratePageableHelpers = false,
        };

        var file = Sources.PageableHelpers(settings);

        // When pageable helpers are off, the file is emitted empty.
        file.Text.Should().BeEmpty();
    }
}
