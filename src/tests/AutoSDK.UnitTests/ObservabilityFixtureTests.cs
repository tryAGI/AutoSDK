using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class ObservabilityFixtureTests
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
    public void IngestionLifecycleFixture_RetainsBatchQueueFlushAndShutdownSignals()
    {
        var yaml = TestSpecCache.GetText("observability-ingestion-lifecycle.yaml");
        var settings = DefaultSettings;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Select(x => x.Id).Should().Contain("GetIngestionConfig");
        data.Methods.Select(x => x.Id).Should().Contain("BatchIngestTraceEvents");
        data.Methods.Select(x => x.Id).Should().Contain("GetIngestionStatus");
        data.Classes.Select(x => x.ClassName).Should().Contain("TraceIngestionBatchRequest");
        data.Classes.Select(x => x.ClassName).Should().Contain("IngestionClientOptions");
        data.Classes.Select(x => x.ClassName).Should().Contain("TraceEvent");

        var httpFile = GenerateHttpFile(yaml, "observability-ingestion");

        httpFile.Should().Contain("\"client_options\"");
        httpFile.Should().Contain("\"tracing_enabled\"");
        httpFile.Should().Contain("\"flush_at\"");
        httpFile.Should().Contain("\"flush_interval_ms\"");
        httpFile.Should().Contain("\"queue_size\"");
        httpFile.Should().Contain("\"shutdown_timeout_ms\"");
        httpFile.Should().Contain("\"sample_rate\"");
        httpFile.Should().Contain("\"trace_start\"");
        httpFile.Should().Contain("## Links");
        httpFile.Should().Contain("# 202.getIngestionStatus");
        httpFile.Should().Contain("# OperationId: getIngestionStatus");
        httpFile.Should().Contain("# Parameters.batchId: $response.body#/batch_id");
    }

    [TestMethod]
    public void DynamicMultipartFixture_RetainsAttachmentMapAndPartNameSignals()
    {
        var yaml = TestSpecCache.GetText("dynamic-multipart-attachments.yaml");
        var settings = DefaultSettings;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Methods.Select(x => x.Id).Should().Contain("CreateRunsMultipart");
        data.Methods.Select(x => x.Id).Should().Contain("GetRun");
        data.Classes.Select(x => x.ClassName).Should().Contain("RunMultipartRequest");
        data.Classes.Select(x => x.ClassName).Should().Contain("MultipartIngestionResponse");
        data.Classes.Select(x => x.ClassName).Should().Contain("AttachmentMetadata");

        var httpFile = GenerateHttpFile(yaml, "dynamic-multipart");

        httpFile.Should().Contain("Content-Type: multipart/form-data");
        httpFile.Should().Contain("attachment.{{run_id}}.{{attachment_key}}");
        httpFile.Should().Contain("application/octet-stream");
        httpFile.Should().Contain("## Links");
        httpFile.Should().Contain("# 202.getRun");
        httpFile.Should().Contain("# OperationId: getRun");
        httpFile.Should().Contain("# Parameters.runId: $response.body#/run_ids/0");
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
