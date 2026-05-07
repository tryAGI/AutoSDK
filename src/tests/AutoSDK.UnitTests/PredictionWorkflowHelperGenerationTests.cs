using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PredictionWorkflowHelperGenerationTests
{
    [TestMethod]
    public void PredictionWorkflowHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Predictions",
        };

        var file = Sources.PredictionWorkflowHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void PredictionWorkflowHelpers_WithCustomClassName_GeneratesConfiguredRunner()
    {
        var settings = Settings.Default with
        {
            Namespace = "Predictions",
            GeneratePredictionWorkflowHelpers = true,
            PredictionWorkflowHelperClassName = "ProviderPredictionRunner",
        };

        var file = Sources.PredictionWorkflowHelpers(settings);

        file.Name.Should().Be("Predictions.ProviderPredictionRunner.g.cs");
        file.Text.Should().Contain("public sealed class ProviderPredictionRunner<TCreateRequest, TEnvelope, TResult>");
        file.Text.Should().Contain("public sealed class PredictionWorkflowMetadata");
        file.Text.Should().Contain("public sealed class PredictionWorkflowOptions");
        file.Text.Should().Contain("public sealed class PredictionWorkflowResult<TEnvelope, TResult>");
        file.Text.Should().Contain("public sealed class PredictionResourceActions<TEnvelope>");
        file.Text.Should().Contain("RunAsync(");
        file.Text.Should().Contain("CreateAndWaitForEnvelopeAsync(");
        file.Text.Should().Contain("RunForResultAsync(");
        file.Text.Should().Contain("PredictionWorkflowException");
        file.Text.Should().Contain("PredictionWorkflowTimeoutException");
    }
}
