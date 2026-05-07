using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class WorkflowLifecycleFixtureTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "Api",
        TargetFramework = "net8.0",
        GenerateSdk = true,
        GenerateModels = true,
        GenerateMethods = true,
    };

    [TestMethod]
    public void ReplicateFixture_RetainsCreateWaitAndFollowUpSignals()
    {
        var yaml = TestSpecCache.GetText("workflow-lifecycle-replicate.yaml");
        var settings = DefaultSettings;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Select(x => x.Id).Should().Contain("CreatePrediction");
        data.Methods.Select(x => x.Id).Should().Contain("GetPrediction");
        data.Methods.Select(x => x.Id).Should().Contain("CancelPrediction");
        data.Classes.Select(x => x.ClassName).Should().Contain("PredictionRequest");
        data.Classes.Select(x => x.ClassName).Should().Contain("Prediction");

        var httpFile = GenerateHttpFile(yaml, "replicate-workflow");

        httpFile.Should().Contain("Prefer: {{Prefer}}");
        httpFile.Should().Contain("## Links");
        httpFile.Should().Contain("# 201.getPrediction");
        httpFile.Should().Contain("# OperationId: getPrediction");
        httpFile.Should().Contain("# Parameters.predictionId: $response.body#/id");
        httpFile.Should().Contain("# 201.cancelPrediction");
        httpFile.Should().Contain("# OperationId: cancelPrediction");
    }

    [TestMethod]
    public void ApifyFixture_RetainsStartWaitDatasetWorkflowSignals()
    {
        var yaml = TestSpecCache.GetText("workflow-lifecycle-apify.yaml");
        var settings = DefaultSettings;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Select(x => x.Id).Should().Contain("StartActorRun");
        data.Methods.Select(x => x.Id).Should().Contain("GetActorRun");
        data.Methods.Select(x => x.Id).Should().Contain("ListDatasetItems");
        data.Classes.Select(x => x.ClassName).Should().Contain("ActorRun");

        var httpFile = GenerateHttpFile(yaml, "apify-workflow");

        httpFile.Should().Contain("waitForFinish");
        httpFile.Should().Contain("## Links");
        httpFile.Should().Contain("# 201.getActorRun");
        httpFile.Should().Contain("# OperationId: getActorRun");
        httpFile.Should().Contain("# Parameters.runId: $response.body#/id");
        httpFile.Should().Contain("# 201.listDatasetItems");
        httpFile.Should().Contain("# OperationId: listDatasetItems");
        httpFile.Should().Contain("# Parameters.datasetId: $response.body#/defaultDatasetId");
    }

    private static string GenerateHttpFile(string yaml, string fileName)
    {
        var settings = (CSharpSettings)DefaultSettings;
        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var operations = document.GetOperations(settings, globalSettings: settings, filteredSchemas: schemas);

        return Sources.GenerateHttpFile(fileName, operations);
    }
}
