using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class WebhookVerifierGenerationTests
{
    [TestMethod]
    public void WebhookVerifier_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Hooks",
        };

        var file = Sources.WebhookVerifier(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void WebhookVerifier_WithCustomMetadata_GeneratesConfiguredVerifier()
    {
        var settings = Settings.Default with
        {
            Namespace = "Hooks",
            GenerateWebhookVerifier = true,
            WebhookVerifierClassName = "ProviderWebhookVerifier",
            WebhookIdHeaderName = "x-provider-id",
            WebhookTimestampHeaderName = "x-provider-timestamp",
            WebhookSignatureHeaderName = "x-provider-signature",
            WebhookSignatureVersion = "v2",
            WebhookTimestampToleranceSeconds = 120,
        };

        var file = Sources.WebhookVerifier(settings);

        file.Name.Should().Be("Hooks.ProviderWebhookVerifier.g.cs");
        file.Text.Should().Contain("public sealed class ProviderWebhookVerifier");
        file.Text.Should().Contain("public const string IdHeaderName = \"x-provider-id\";");
        file.Text.Should().Contain("public const string TimestampHeaderName = \"x-provider-timestamp\";");
        file.Text.Should().Contain("public const string SignatureHeaderName = \"x-provider-signature\";");
        file.Text.Should().Contain("public const string SignatureVersion = \"v2\";");
        file.Text.Should().Contain("global::System.TimeSpan.FromSeconds(120)");
        file.Text.Should().Contain("const string encodedSecretPrefix = \"whsec_\";");
        file.Text.Should().Contain("global::System.Security.Cryptography.HMACSHA256");
        file.Text.Should().Contain("FixedTimeEquals(expectedSignature, candidateSignature)");
        file.Text.Should().Contain("global::System.Net.Http.HttpRequestMessage request");
        file.Text.Should().Contain("global::System.Collections.Generic.IReadOnlyDictionary<string, string> headers");
    }
}
