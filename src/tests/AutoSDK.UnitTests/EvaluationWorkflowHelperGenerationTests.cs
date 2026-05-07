using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class EvaluationWorkflowHelperGenerationTests
{
    [TestMethod]
    public void EvaluationWorkflowHelpers_WhenDisabled_ReturnsEmptyFile()
    {
        var settings = Settings.Default with
        {
            Namespace = "Evaluations",
        };

        var file = Sources.EvaluationWorkflowHelpers(settings);

        file.Should().Be(FileWithName.Empty);
    }

    [TestMethod]
    public void EvaluationWorkflowHelpers_WithCustomClassName_GeneratesConfiguredRunner()
    {
        var settings = Settings.Default with
        {
            Namespace = "Evaluations",
            GenerateEvaluationWorkflowHelpers = true,
            EvaluationWorkflowHelperClassName = "ProviderEvalRunner",
        };

        var file = Sources.EvaluationWorkflowHelpers(settings);

        file.Name.Should().Be("Evaluations.ProviderEvalRunner.g.cs");
        file.Text.Should().Contain("public sealed class ProviderEvalRunner<TItem, TOutput>");
        file.Text.Should().Contain("public sealed class EvaluationWorkflowMetadata");
        file.Text.Should().Contain("public sealed class EvaluationWorkflowOptions");
        file.Text.Should().Contain("public sealed class EvaluationTaskContext<TItem>");
        file.Text.Should().Contain("public sealed class EvaluationTaskResult<TOutput>");
        file.Text.Should().Contain("public sealed class EvaluationScorer<TItem, TOutput>");
        file.Text.Should().Contain("public sealed class EvaluationWorkflowResult<TItem, TOutput>");
        file.Text.Should().Contain("MaxConcurrency");
        file.Text.Should().Contain("PublishBatchSize");
        file.Text.Should().Contain("RunAsync(");
    }
}
