using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class RetryHandlerTests
{
    [TestMethod]
    public void RetryOptions_WhenHandlerDisabled_DefaultsToSingleAttempt()
    {
        var settings = Settings.Default with { Namespace = "Demo" };

        var source = Sources.GenerateOptionsSupport(settings);

        source.Should().Contain("public int MaxAttempts { get; set; } = 1;");
        source.Should().Contain("public global::System.TimeSpan InitialDelay { get; set; } = global::System.TimeSpan.FromSeconds(1);");
        // 409 is not retried unless the handler flag opts in.
        source.Should().NotContain("409 => true,");
    }

    [TestMethod]
    public void RetryOptions_WhenHandlerEnabled_UsesVendorSdkDefaults()
    {
        var settings = Settings.Default with
        {
            Namespace = "Demo",
            GenerateRetryHandler = true,
        };

        var source = Sources.GenerateOptionsSupport(settings);

        source.Should().Contain("public int MaxAttempts { get; set; } = 3;");
        source.Should().Contain("public global::System.TimeSpan InitialDelay { get; set; } = global::System.TimeSpan.FromMilliseconds(500);");
        source.Should().Contain("409 => true,");
        // 408/429/5xx remain retried regardless of the flag.
        source.Should().Contain("408 => true,");
        source.Should().Contain("429 => true,");
        source.Should().Contain("503 => true,");
        // BackoffMultiplier stays 2x.
        source.Should().Contain("public double BackoffMultiplier { get; set; } = 2D;");
        // Retry-After honoring stays on.
        source.Should().Contain("public bool UseRetryAfterHeader { get; set; } = true;");
    }
}
