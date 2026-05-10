using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class PollingGenerationTests
{
    private static CSharpSettings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
        GenerateSdk = true,
        GenerateConstructors = true,
    };

    [TestMethod]
    public void GenerateMethod_WithSpeakeasyPolling_EmitsWaitHelperAndSupport()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Polling
                              version: 1.0.0
                            paths:
                              /jobs/{id}:
                                get:
                                  operationId: getJob
                                  parameters:
                                    - in: path
                                      name: id
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            required:
                                              - status
                                            properties:
                                              status:
                                                type: string
                                                enum:
                                                  - pending
                                                  - completed
                                                  - errored
                                  x-speakeasy-polling:
                                    - name: WaitForCompleted
                                      delaySeconds: 2
                                      intervalSeconds: 4
                                      limitCount: 12
                                      failureCriteria:
                                        - condition: $statusCode == 200
                                        - condition: $response.body#/status == "errored"
                                      successCriteria:
                                        - condition: $statusCode == 200
                                        - condition: $response.body#/status == "completed"
                            """;

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;
        var interfaceSource = Sources.MethodInterface(method).Text;
        var supportSource = Sources.OptionsSupport(settings, includePollingSupport: true).Text;

        methodSource.Should().Contain("GetJobWaitForCompletedAsync(");
        methodSource.Should().Contain("await GetJobAsResponseAsync(");
        methodSource.Should().Contain("AutoSDKPollingSupport.ResolvePollingOptions(");
        methodSource.Should().Contain("AutoSDKPollingSupport.MatchesStatusCode(");
        methodSource.Should().Contain("AutoSDKPollingSupport.MatchesSimpleCondition(");
        methodSource.Should().Contain("AutoSDKPollingException(");

        interfaceSource.Should().Contain("GetJobWaitForCompletedAsync(");
        interfaceSource.Should().Contain("global::G.AutoSDKPollingOptions? pollingOptions = default");

        supportSource.Should().Contain("public sealed class AutoSDKPollingOptions");
        supportSource.Should().Contain("public sealed class AutoSDKPollingException");
        supportSource.Should().Contain("internal static class AutoSDKPollingSupport");
    }

    [TestMethod]
    public void GenerateMethod_WithAutoDetectStatusPolling_EmitsWaitHelperFromOneOfDiscriminator()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: AutoStatusPolling
                              version: 1.0.0
                            paths:
                              /v1/tasks/{id}:
                                get:
                                  operationId: getTask
                                  parameters:
                                    - in: path
                                      name: id
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            oneOf:
                                              - type: object
                                                required: [status]
                                                properties:
                                                  status:
                                                    type: string
                                                    enum: [PENDING]
                                              - type: object
                                                required: [status]
                                                properties:
                                                  status:
                                                    type: string
                                                    enum: [SUCCEEDED]
                                                  output:
                                                    type: array
                                                    items:
                                                      type: string
                                              - type: object
                                                required: [status]
                                                properties:
                                                  status:
                                                    type: string
                                                    enum: [FAILED]
                                                  failure:
                                                    type: string
                                            discriminator:
                                              propertyName: status
                            """;

        var settings = DefaultSettings with { AutoDetectStatusPolling = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        methodSource.Should().Contain("GetTaskWaitAsync(");
        methodSource.Should().Contain("AutoSDKPollingSupport.MatchesRegexCondition(");
        methodSource.Should().Contain("/status");
        methodSource.Should().Contain("SUCCEEDED");
        methodSource.Should().Contain("FAILED");
    }

    [TestMethod]
    public void AutoDetectStatusPolling_WithoutTerminalSuccessState_GeneratesNoWaitHelper()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: NoAutoDetect
                              version: 1.0.0
                            paths:
                              /v1/jobs/{id}:
                                get:
                                  operationId: getJob
                                  parameters:
                                    - in: path
                                      name: id
                                      required: true
                                      schema:
                                        type: string
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              status:
                                                type: string
                                                enum: [running, paused]
                            """;

        var settings = DefaultSettings with { AutoDetectStatusPolling = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        methodSource.Should().NotContain("WaitAsync(");
    }
}
