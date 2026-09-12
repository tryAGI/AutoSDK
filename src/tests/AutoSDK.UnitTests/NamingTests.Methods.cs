using AutoSDK.Models;
using AutoSDK.Enrichment;
using AutoSDK.Generation;
using AutoSDK.Naming.Methods;
using AutoSDK.Extensions;
using AutoSDK.Helpers;
using AutoSDK.Naming.Models;
using AutoSDK.TypeMapping;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class NamingTests
{
    [TestMethod]
    [DataRow("media_transcribe", "media", "Transcribe")]
    [DataRow("media-transcribe", "media", "Transcribe")]
    [DataRow("mediaTranscribe", "media", "Transcribe")]
    [DataRow("speechToText_transcribe", "speech-to-text", "Transcribe")]
    [DataRow("deployment_list", "deployments", "List")]
    [DataRow("deployments_list", "deployments", "List")]
    [DataRow("metadata_get", "media", "MetadataGet")]
    [DataRow("media", "media", "Media")]
    public void OperationIdMethodNames_StripOnlyRedundantTagPrefixes(
        string operationId,
        string tag,
        string expectedMethodName)
    {
        var operations = PrepareOperations($$"""
                                           paths:
                                             /items:
                                               get:
                                                 tags:
                                                   - {{tag}}
                                                 operationId: {{operationId}}
                                                 responses:
                                                   '200':
                                                     description: OK
                                           """);

        operations.Should().ContainSingle()
            .Which.MethodName.Should().Be(expectedMethodName);
    }

    [TestMethod]
    public void OperationIdMethodNames_ResolveCollisionsAfterStrippingRedundantTagPrefixes()
    {
        var operations = PrepareOperations("""
                                           paths:
                                             /first:
                                               get:
                                                 tags:
                                                   - media
                                                 operationId: media_transcribe
                                                 responses:
                                                   '200':
                                                     description: OK
                                             /second:
                                               get:
                                                 tags:
                                                   - media
                                                 operationId: transcribe
                                                 responses:
                                                   '200':
                                                     description: OK
                                           """);

        ModelNameGenerator.ResolveCollisions(operations);

        operations.Select(static operation => operation.MethodName)
            .Should().Equal("Transcribe", "Transcribe2");
    }

    [TestMethod]
    public void OperationIdMethodNames_PreserveExistingTagPrefixesByDefault()
    {
        var operations = PrepareOperations("""
                                           paths:
                                             /items:
                                               get:
                                                 tags:
                                                   - media
                                                 operationId: media_transcribe
                                                 responses:
                                                   '200':
                                                     description: OK
                                           """, stripRedundantTagPrefixes: false);

        operations.Should().ContainSingle()
            .Which.MethodName.Should().Be("MediaTranscribe");
    }

    [TestMethod]
    public void OperationIdModelNames_StripTheSameRedundantTagPrefixAsMethods()
    {
        var settings = Settings.Default with
        {
            Namespace = "TestSdk",
            ClassName = "TestClient",
            MethodNamingConvention = MethodNamingConvention.OperationId,
            StripRedundantOperationIdTagPrefixes = true,
        };
        var document = """
                       openapi: 3.0.1
                       info:
                         title: Test
                         version: 1.0.0
                       paths:
                         /synthesize:
                           post:
                             tags:
                               - textToSpeech
                             operationId: textToSpeech_synthesize
                             requestBody:
                               content:
                                 application/json:
                                   schema:
                                     type: object
                                     properties:
                                       text:
                                         type: string
                             responses:
                               '200':
                                 description: OK
                       """.GetOpenApiDocument(settings);

        var request = document.GetSchemas(settings)
            .Single(schema => schema.Hint == Hint.Request);

        request.ComputeClassName().Should().Be("SynthesizeRequest");
    }

    [TestMethod]
    public void SummaryMethodNames_RemoveApostrophesFromIdentifiers()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        var operation = new OpenApiOperation
        {
            Summary = "Get the authenticated user's Slack ID",
        };

        var context = CSharpOperationContextFactory.CreateOperationContext(
            settings: settings,
            globalSettings: settings,
            operation: operation,
            operationPath: "/me/slack_id",
            operationType: System.Net.Http.HttpMethod.Get,
            operationSchemas: null,
            effectiveServers: [],
            hasServerOverride: false,
            globalSecurityRequirements: []);
        var endPoint = CSharpEndPointFactory.CreateEndPoint(context);

        context.MethodName.Should().Be("GetTheAuthenticatedUsersSlackId");
        endPoint.NotAsyncMethodName.Should().Be("GetTheAuthenticatedUsersSlackId");
        endPoint.MethodName.Should().Be("GetTheAuthenticatedUsersSlackIdAsync");
        endPoint.FileNameWithoutExtension.Should().Be("LangSmith.LangSmithClient.GetTheAuthenticatedUsersSlackId");
        endPoint.InterfaceFileNameWithoutExtension.Should().Be("LangSmith.ILangSmithClient.GetTheAuthenticatedUsersSlackId");
    }

    [TestMethod]
    public void SummaryMethodNames_StripExperimentalPrefixesFromIdentifiers()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        var operation = new OpenApiOperation
        {
            Summary = "[Beta] Get Insights Jobs",
        };

        var context = CSharpOperationContextFactory.CreateOperationContext(
            settings: settings,
            globalSettings: settings,
            operation: operation,
            operationPath: "/sessions/{session_id}/insights",
            operationType: System.Net.Http.HttpMethod.Get,
            operationSchemas: null,
            effectiveServers: [],
            hasServerOverride: false,
            globalSecurityRequirements: []);
        var endPoint = CSharpEndPointFactory.CreateEndPoint(context);

        context.MethodName.Should().Be("GetInsightsJobs");
        endPoint.NotAsyncMethodName.Should().Be("GetInsightsJobs");
        endPoint.MethodName.Should().Be("GetInsightsJobsAsync");
        endPoint.ExperimentalStage.Should().Be("Beta");
    }

    [TestMethod]
    public void FernAvailabilityBeta_MapsToExperimentalStage()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /insights:
                                get:
                                  summary: Get Insights Jobs
                                  x-fern-availability: beta
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var context = document.GetOperations(settings, globalSettings: settings, filteredSchemas: schemas).Single();
        var endPoint = CSharpEndPointFactory.CreateEndPoint(context);

        context.MethodName.Should().Be("GetInsightsJobs");
        endPoint.MethodName.Should().Be("GetInsightsJobsAsync");
        endPoint.ExperimentalStage.Should().Be("Beta");
    }

    [TestMethod]
    public void FernAvailabilityDeprecated_MapsToDeprecatedOperation()
    {
        var settings = Settings.Default with
        {
            Namespace = "LangSmith",
            ClassName = "LangSmithClient",
            ClsCompliantEnumPrefix = "x",
            MethodNamingConvention = MethodNamingConvention.Summary,
        };
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: Test
                              version: 1.0.0
                            paths:
                              /old:
                                get:
                                  summary: Old endpoint
                                  x-fern-availability: deprecated
                                  responses:
                                    '200':
                                      description: OK
                            """;

        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var context = document.GetOperations(settings, globalSettings: settings, filteredSchemas: schemas).Single();
        var endPoint = CSharpEndPointFactory.CreateEndPoint(context);

        context.Operation.IsDeprecated().Should().BeTrue();
        endPoint.IsDeprecated.Should().BeTrue();
        endPoint.ExperimentalStage.Should().BeEmpty();
    }

    [TestMethod]
    public void FernAvailabilityDeprecated_MapsToDeprecatedSchemaAndProperty()
    {
        var models = PrepareModels("""
                                  openapi: 3.0.1
                                  info:
                                    title: Test
                                    version: 1.0.0
                                  components:
                                    schemas:
                                      DeprecatedModel:
                                        type: object
                                        x-fern-availability: deprecated
                                        properties:
                                          old_value:
                                            type: string
                                            x-fern-availability: deprecated
                                  """);
        foreach (var model in models)
        {
            model.ComputeData(
                CSharpModelDataFactory.CreateModelData,
                CSharpTypeMapper.CreateTypeData,
                static type => type.WithCSharpComputedValues(),
                CSharpTypeMapper.GetCSharpType,
                CSharpTypeMapper.GetCSharpNullability,
                CSharpSchemaDataFactory.CreatePropertyData,
                CSharpSchemaDataFactory.CreateMethodParameter,
                CSharpSchemaDataFactory.CreateAnyOfData);
        }

        var modelData = models.Should().ContainSingle().Subject.ClassData;
        modelData.Should().NotBeNull();
        var property = modelData!.Value.Properties.Should().ContainSingle().Subject;

        modelData.Value.IsDeprecated.Should().BeTrue();
        property.IsDeprecated.Should().BeTrue();
        property.Type.IsDeprecated.Should().BeTrue();
    }

    private static IReadOnlyList<OperationContext> PrepareOperations(
        string paths,
        bool stripRedundantTagPrefixes = true)
    {
        var settings = Settings.Default with
        {
            Namespace = "TestSdk",
            ClassName = "TestClient",
            MethodNamingConvention = MethodNamingConvention.OperationId,
            StripRedundantOperationIdTagPrefixes = stripRedundantTagPrefixes,
        };
        var yaml = $$"""
                     openapi: 3.0.1
                     info:
                       title: Test
                       version: 1.0.0
                     {{paths}}
                     """;
        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);

        return document.GetOperations(settings, globalSettings: settings, filteredSchemas: schemas);
    }
}
