using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class MultipartUploadHelpersTests
{
    [TestMethod]
    public void Helpers_WhenDisabled_OmitFile()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void Helpers_WhenEnabled_EmitsTypedUploadFileWithFactories()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateMultipartUploadHelpers = true,
        };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Name.Should().Be("Demo.AutoSDKUploadFile.g.cs");
        file.Text.Should().Contain("public sealed class AutoSDKUploadFile");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromBytes(");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromStream(");
        file.Text.Should().Contain("public static AutoSDKUploadFile FromPath(");
        file.Text.Should().Contain("public string Filename { get; }");
        file.Text.Should().Contain("public string ContentType { get; }");
        file.Text.Should().Contain("public global::System.Net.Http.HttpContent ToHttpContent(string formFieldName)");
        // Mime guesser is also emitted.
        file.Text.Should().Contain("public static class AutoSDKMimeTypeGuesser");
        file.Text.Should().Contain("\".pdf\" => \"application/pdf\"");
        file.Text.Should().Contain("\".jpg\" or \".jpeg\" => \"image/jpeg\"");
        file.Text.Should().Contain("\".mp3\" => \"audio/mpeg\"");
        file.Text.Should().Contain("\".mp4\" => \"video/mp4\"");
        // Stream-vs-bytes guard rails.
        file.Text.Should().Contain("public global::System.ReadOnlyMemory<byte> Bytes");
        file.Text.Should().Contain("public global::System.IO.Stream OpenReadStream()");
    }

    [TestMethod]
    public void Helpers_HonorCustomClassName()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateMultipartUploadHelpers = true,
            MultipartUploadHelperClassName = "PortablesFile",
        };

        var file = Sources.MultipartUploadHelpers(settings);

        file.Name.Should().Be("Demo.PortablesFile.g.cs");
        file.Text.Should().Contain("public sealed class PortablesFile");
        file.Text.Should().Contain("public static PortablesFile FromBytes(");
    }
}
