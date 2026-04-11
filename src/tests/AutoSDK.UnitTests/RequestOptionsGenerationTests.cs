using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class RequestOptionsGenerationTests
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
    public void GenerateClient_WithOptionsSupport_EmitsClientOptionsSurface()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Options
                              version: 1.0.0
                            paths:
                              /charges:
                                post:
                                  operationId: createCharge
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            type: object
                                            properties:
                                              id:
                                                type: string
                            """;

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var mainClient = data.Clients.Single(x => x.Id == "MainConstructor");
        var clientSource = Sources.Client(mainClient).Text;
        var supportSource = Sources.OptionsSupport(settings).Text;

        clientSource.Should().Contain("public global::G.AutoSDKClientOptions Options { get; }");
        clientSource.Should().Contain("global::G.AutoSDKClientOptions? options = null");
        clientSource.Should().Contain("Options = options ?? new global::G.AutoSDKClientOptions();");
        clientSource.Should().Contain("bool disposeHttpClient = true) : this(");
        clientSource.Should().Contain("options: null,");

        supportSource.Should().Contain("public sealed class AutoSDKClientOptions");
        supportSource.Should().Contain("public sealed class AutoSDKRequestOptions");
        supportSource.Should().Contain("public sealed class AutoSDKRetryOptions");
        supportSource.Should().Contain("public interface IAutoSDKHook");
        supportSource.Should().Contain("public sealed class AutoSDKHookContext");
        supportSource.Should().Contain("public global::System.Collections.Generic.List<global::G.IAutoSDKHook> Hooks { get; }");
        supportSource.Should().Contain("public global::G.AutoSDKClientOptions AddHook(");
        supportSource.Should().NotContain("public sealed class AutoSDKPollingOptions");
        supportSource.Should().NotContain("public sealed class AutoSDKPollingException");
    }

    [TestMethod]
    public void GenerateMethod_WithRequestOptions_EmitsPerRequestOverridesAndRetries()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: RequestOptions
                              version: 1.0.0
                            paths:
                              /search:
                                get:
                                  operationId: search
                                  parameters:
                                    - in: query
                                      name: q
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
                                              id:
                                                type: string
                            """;

        var settings = DefaultSettings;
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var methodSource = Sources.Method(method).Text;

        methodSource.Should().Contain("global::G.AutoSDKRequestOptions? requestOptions = default");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.AppendQueryParameters(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.ApplyHeaders(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.GetMaxAttempts(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode)");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterErrorAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.CreateHookContext(");
        methodSource.Should().Contain("if (__effectiveReadResponseAsString)");
    }
}
