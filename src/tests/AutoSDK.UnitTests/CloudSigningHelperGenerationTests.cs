using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class CloudSigningHelperGenerationTests
{
    [TestMethod]
    public void CloudSigningHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Cloud",
        };

        var file = Sources.CloudSigningHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void CloudSigningHelpers_WithCustomClassName_GeneratesConfiguredFactory()
    {
        var settings = Settings.Default with
        {
            Namespace = "Cloud",
            GenerateCloudSigningHelpers = true,
            CloudSigningHelperClassName = "ProviderCloudSigner",
        };

        var file = Sources.CloudSigningHelpers(settings);

        file.Name.Should().Be("Cloud.ProviderCloudSigner.g.cs");
        file.Text.Should().Contain("public static class ProviderCloudSigner");
        file.Text.Should().Contain("public sealed class CloudSigningMetadata");
        file.Text.Should().Contain("public sealed class CloudCredential");
        file.Text.Should().Contain("public sealed class CloudRequestSigningHook");
        file.Text.Should().Contain("public sealed class AwsSigV4RequestSigner");
        file.Text.Should().Contain("public sealed class AzureApiKeyRequestSigner");
        file.Text.Should().Contain("public sealed class AzureBearerTokenRequestSigner");
        file.Text.Should().Contain("public sealed class TencentTc3RequestSigner");
        file.Text.Should().Contain("ICloudRequestSigner");
        file.Text.Should().Contain("AWS4-HMAC-SHA256");
        file.Text.Should().Contain("TC3-HMAC-SHA256");
    }
}
