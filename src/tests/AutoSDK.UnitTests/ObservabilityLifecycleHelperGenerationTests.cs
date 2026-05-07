using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class ObservabilityLifecycleHelperGenerationTests
{
    [TestMethod]
    public void ObservabilityLifecycleHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Telemetry",
        };

        var file = Sources.ObservabilityLifecycleHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void ObservabilityLifecycleHelpers_WithCustomClassName_GeneratesConfiguredLifecycle()
    {
        var settings = Settings.Default with
        {
            Namespace = "Telemetry",
            GenerateObservabilityLifecycleHelpers = true,
            ObservabilityLifecycleHelperClassName = "ProviderTelemetryLifecycle",
        };

        var file = Sources.ObservabilityLifecycleHelpers(settings);

        file.Name.Should().Be("Telemetry.ProviderTelemetryLifecycle.g.cs");
        file.Text.Should().Contain("public sealed class ProviderTelemetryLifecycle");
        file.Text.Should().Contain("public sealed class ObservabilityIngestionOptions");
        file.Text.Should().Contain("public sealed class ObservabilityIngestionEvent");
        file.Text.Should().Contain("FromEnvironment()");
        file.Text.Should().Contain("FlushAsync(");
        file.Text.Should().Contain("ShutdownAsync(");
        file.Text.Should().Contain("IAsyncDisposable");
        file.Text.Should().Contain("EventDropped");
        file.Text.Should().Contain("FlushFailed");
    }
}
