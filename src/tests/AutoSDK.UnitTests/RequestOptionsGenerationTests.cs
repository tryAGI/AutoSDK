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
        clientSource.Should().Contain("global::G.AutoSDKClientOptions? options,");
        clientSource.Should().NotContain("global::G.AutoSDKClientOptions? options = null");
        clientSource.Should().Contain("Options = options ?? new global::G.AutoSDKClientOptions();");
        clientSource.Should().Contain("bool disposeHttpClient = true) : this(");
        clientSource.Should().Contain("options: null,");

        supportSource.Should().Contain("public sealed class AutoSDKClientOptions");
        supportSource.Should().Contain("public sealed class AutoSDKRequestOptions");
        supportSource.Should().Contain("public sealed class AutoSDKRetryOptions");
        supportSource.Should().Contain("public global::System.TimeSpan InitialDelay { get; set; } = global::System.TimeSpan.FromSeconds(1);");
        supportSource.Should().Contain("public global::System.TimeSpan MaxDelay { get; set; } = global::System.TimeSpan.FromSeconds(30);");
        supportSource.Should().Contain("public double BackoffMultiplier { get; set; } = 2D;");
        supportSource.Should().Contain("public double JitterRatio { get; set; } = 0.2D;");
        supportSource.Should().Contain("public bool UseRetryAfterHeader { get; set; } = true;");
        supportSource.Should().Contain("public interface IAutoSDKHook");
        supportSource.Should().Contain("public sealed class AutoSDKHookContext");
        supportSource.Should().Contain("public global::System.TimeSpan? RetryDelay { get; set; }");
        supportSource.Should().Contain("public string RetryReason { get; set; } = string.Empty;");
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
        methodSource.Should().Contain("supportsRetry: true");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.GetRetryDelay(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode)");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(");
        methodSource.Should().Contain("retryDelay: __retryDelay");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.OnAfterErrorAsync(");
        methodSource.Should().Contain("AutoSDKRequestOptionsSupport.CreateHookContext(");
        methodSource.Should().Contain("if (__effectiveReadResponseAsString)");
    }

    [TestMethod]
    public void GenerateRetrySupport_EmitsRetryAfterBackoffJitterAndRateLimitResetHandling()
    {
        var supportSource = Sources.OptionsSupport(DefaultSettings).Text;

        supportSource.Should().Contain("retryAfter.Delta.HasValue");
        supportSource.Should().Contain("retryAfter.Date.HasValue");
        supportSource.Should().Contain("TryGetRateLimitResetDelay(");
        supportSource.Should().Contain("DateTimeOffset.FromUnixTimeSeconds");
        supportSource.Should().Contain("global::System.Math.Pow(multiplier, exponent)");
        supportSource.Should().Contain("s_retryJitterRandom.NextDouble()");
        supportSource.Should().Contain("1D - jitterRatio + (sample * jitterRatio * 2D)");
        supportSource.Should().Contain("ClampRetryDelay(");
    }

    [TestMethod]
    public void GenerateMethod_WithMultipartRequest_DisablesGeneratedRetriesByDefault()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: MultipartRetry
                              version: 1.0.0
                            paths:
                              /uploads:
                                post:
                                  operationId: upload
                                  requestBody:
                                    required: true
                                    content:
                                      multipart/form-data:
                                        schema:
                                          type: object
                                          required: [file]
                                          properties:
                                            file:
                                              type: string
                                              format: binary
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

        method.IsMultipartFormData.Should().BeTrue();
        methodSource.Should().Contain("supportsRetry: false");
    }

    [TestMethod]
    public void GenerateHttpResilienceExtensions_EmitsOptInMicrosoftResilienceBuilderExtension()
    {
        var settings = DefaultSettings with
        {
            GenerateHttpResilienceExtensions = true,
        };

        var source = Sources.HttpResilienceExtensions(settings).Text;

        source.Should().Contain("public static class AutoSDKHttpResilienceExtensions");
        source.Should().Contain("AddAutoSDKStandardResilienceHandler(");
        source.Should().Contain("global::Microsoft.Extensions.DependencyInjection.IHttpClientBuilder");
        source.Should().Contain("global::Microsoft.Extensions.DependencyInjection.ResilienceHttpClientBuilderExtensions.AddStandardResilienceHandler");
        source.Should().Contain("#pragma warning disable EXTEXP0001");
        source.Should().Contain("global::Microsoft.Extensions.Http.Resilience.HttpRetryStrategyOptionsExtensions.DisableForUnsafeHttpMethods(options.Retry);");
        source.Should().Contain("return builder;");
    }

    [TestMethod]
    public void GenerateDependencyInjection_EmitsTypedHttpClientRegistration()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: DependencyInjection
                              version: 1.0.0
                            servers:
                              - url: https://api.example.com
                            paths:
                              /charges:
                                get:
                                  operationId: listCharges
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

        var settings = DefaultSettings with
        {
            Namespace = "IXSocial",
            ClassName = "IXSocialClient",
            GenerateDependencyInjection = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var mainClient = data.Clients.Single(x => x.Id == "MainConstructor");
        var source = Sources.DependencyInjection(mainClient).Text;

        source.Should().Contain("public static class DependencyInjectionExtensions");
        source.Should().Contain("public static IServiceCollection AddIXSocialClient(");
        source.Should().Contain("global::System.Uri baseUri");
        source.Should().Contain("global::System.Action<IHttpClientBuilder>? configureHttpClientBuilder = null");
        source.Should().Contain("global::System.Action<global::System.IServiceProvider, global::IXSocial.AutoSDKClientOptions>? configureClientOptions = null");
        source.Should().Contain("services");
        source.Should().Contain(".AddHttpClient<global::IXSocial.IIXSocialClient, global::IXSocial.IXSocialClient>(");
        source.Should().Contain("authorizations: null");
        source.Should().Contain("disposeHttpClient: false");
        source.Should().NotContain(".BindConfiguration(sectionName)");
        source.Should().NotContain("public sealed partial class IXSocialOptions");
    }

    [TestMethod]
    public void GenerateDependencyInjection_WithConfigurationBinding_EmitsOptionsAndValidation()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: DependencyInjection
                              version: 1.0.0
                            servers:
                              - url: https://api.example.com
                            paths:
                              /charges:
                                get:
                                  operationId: listCharges
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

        var settings = DefaultSettings with
        {
            Namespace = "IXSocial",
            ClassName = "IXSocialClient",
            GenerateDependencyInjection = true,
            GenerateConfigurationBinding = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), settings));
        var mainClient = data.Clients.Single(x => x.Id == "MainConstructor");
        var source = Sources.DependencyInjection(mainClient, includeConfigurationBinding: true).Text;

        source.Should().Contain("public sealed partial class IXSocialOptions");
        source.Should().Contain("public const string DefaultConfigurationSectionName = \"IXSocial\";");
        source.Should().Contain("public global::System.Uri? ApiUrl { get; set; }");
        source.Should().Contain("IConfiguration configuration");
        source.Should().Contain(".BindConfiguration(sectionName)");
        source.Should().Contain(".Validate(static options => options.ApiUrl is not null, \"IXSocial:ApiUrl is missing\")");
        source.Should().Contain("optionsBuilder.ValidateOnStart()");
        source.Should().Contain(".GetRequiredService<IOptions<global::IXSocial.IXSocialOptions>>()");
    }
}
