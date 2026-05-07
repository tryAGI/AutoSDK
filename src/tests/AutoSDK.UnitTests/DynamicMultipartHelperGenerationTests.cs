using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class DynamicMultipartHelperGenerationTests
{
    [TestMethod]
    public void DynamicMultipartHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Ingestion",
        };

        var file = Sources.DynamicMultipartHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void DynamicMultipartHelpers_WithCustomClassName_GeneratesConfiguredBuilder()
    {
        var settings = Settings.Default with
        {
            Namespace = "Ingestion",
            GenerateDynamicMultipartHelpers = true,
            DynamicMultipartHelperClassName = "TraceMultipartBuilder",
        };

        var file = Sources.DynamicMultipartHelpers(settings);

        file.Name.Should().Be("Ingestion.TraceMultipartBuilder.g.cs");
        file.Text.Should().Contain("public sealed class TraceMultipartBuilder");
        file.Text.Should().Contain("public sealed class TraceMultipartBuilderAttachment");
        file.Text.Should().Contain("global::System.Net.Http.MultipartFormDataContent Build()");
        file.Text.Should().Contain("AddBytes(");
        file.Text.Should().Contain("AddStream(");
        file.Text.Should().Contain("AddExternalUrl(");
        file.Text.Should().Contain("CreateAttachmentPartName(");
        file.Text.Should().Contain("global::System.Net.Http.Headers.MediaTypeHeaderValue");
    }
}
