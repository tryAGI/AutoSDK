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
    public void GenerateOptionsSupport_EmitsAuthorizationProviderHookSurface()
    {
        var supportSource = Sources.OptionsSupport(DefaultSettings).Text;

        supportSource.Should().Contain("public interface IAutoSDKAuthorizationProvider");
        supportSource.Should().Contain("ResolveAsync(");
        supportSource.Should().Contain("public sealed class AutoSDKAuthorizationProviderHook");
        supportSource.Should().Contain("UseAuthorizationProvider(");
        supportSource.Should().Contain("AuthorizationProvider { get; set; }");
        supportSource.Should().Contain("public readonly struct AutoSDKAuthorizationValue");
        supportSource.Should().Contain("AutoSDKAuthorizationValue Bearer(string token)");
        supportSource.Should().Contain("AutoSDKAuthorizationValue ApiKeyHeader(string name, string value)");
        supportSource.Should().Contain("private static void ApplyAuthorization(");
    }

    [TestMethod]
    public void GeneratePageableHelpers_EmitsOffsetAndCursorPagerWhenOptInFlagIsSet()
    {
        var settings = DefaultSettings with { GeneratePageableHelpers = true };
        var file = Sources.PageableHelpers(settings);

        file.Name.Should().Be("G.AutoSDKPager.g.cs");
        file.Text.Should().Contain("public static class AutoSDKPager");
        file.Text.Should().Contain("OffsetAsync<TPage, TItem>(");
        file.Text.Should().Contain("CursorAsync<TPage, TItem>(");
        file.Text.Should().Contain("[global::System.Runtime.CompilerServices.EnumeratorCancellation]");
        file.Text.Should().Contain("global::System.Collections.Generic.IAsyncEnumerable<TItem>");
        file.Text.Should().Contain("string.Equals(next, cursor, global::System.StringComparison.Ordinal)");
    }

    [TestMethod]
    public void GeneratePageableHelpers_EmitsLinkHeaderPager()
    {
        var settings = DefaultSettings with { GeneratePageableHelpers = true };
        var file = Sources.PageableHelpers(settings);

        file.Text.Should().Contain("LinkHeaderAsync<TPage, TItem>(");
        file.Text.Should().Contain("ParseLinkHeaderRel(");
        file.Text.Should().Contain("private static bool MatchesLinkRel(");
        // Default rel is "next" and the parser handles bracketed URLs and multi-value headers.
        file.Text.Should().Contain("string linkRel = \"next\"");
        file.Text.Should().Contain("var endBracket = part.IndexOf('>');");

        // Convenience overload that auto-reads the Link header from AutoSDKHttpResponse<T>
        // so consumers don't have to write the extractLinkHeader lambda by hand.
        file.Text.Should().Contain("global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<TPage>>");
        file.Text.Should().Contain("response.Headers.TryGetValue(\"Link\", out var values)");
    }

    [TestMethod]
    public void GeneratePageableHelpers_SuppressedWhenOptInFlagIsOff()
    {
        var settings = DefaultSettings with { GeneratePageableHelpers = false };
        var file = Sources.PageableHelpers(settings);

        file.Text.Should().BeEmpty();
    }

    [TestMethod]
    public void AutoPaging_OffsetShape_EmitsAutoPagingCompanionWrappingTheRawMethod()
    {
        // Hume-style shape: `page_number` query parameter plus a response with a single
        // array property. With #291's fix the generator emits a companion that turns
        // the raw page method into an IAsyncEnumerable<TItem> via AutoSDKPager.OffsetAsync.
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: PageableOffset
                              version: 1.0.0
                            paths:
                              /chat-groups:
                                get:
                                  operationId: listChatGroups
                                  parameters:
                                    - in: query
                                      name: page_number
                                      schema:
                                        type: integer
                                    - in: query
                                      name: page_size
                                      schema:
                                        type: integer
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/ReturnPagedChatGroups'
                            components:
                              schemas:
                                ReturnPagedChatGroups:
                                  type: object
                                  required: [chat_groups_page]
                                  properties:
                                    chat_groups_page:
                                      type: array
                                      items:
                                        $ref: '#/components/schemas/ReturnChatGroup'
                                    page_number:
                                      type: integer
                                ReturnChatGroup:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                            """;

        var settings = DefaultSettings with { GeneratePageableHelpers = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var endpoint = data.Methods.Single(m => m.NotAsyncMethodName == "ListChatGroups");

        endpoint.Settings.GeneratePageableHelpers.Should().BeTrue("setting must propagate through to the endpoint");
        endpoint.Parameters.Should().Contain(p => string.Equals(p.Id, "page_number", System.StringComparison.OrdinalIgnoreCase));
        var pageParam = endpoint.Parameters.First(p => string.Equals(p.Id, "page_number", System.StringComparison.OrdinalIgnoreCase));
        pageParam.Location.Should().Be(Microsoft.OpenApi.ParameterLocation.Query, "page_number must be a query parameter");
        endpoint.SuccessResponse.Type.CSharpType.Should().NotBeNullOrWhiteSpace("response must have a typed body");
        endpoint.SuccessResponse.Type.CSharpTypeWithoutNullability.Should().Contain("ReturnPagedChatGroups");
        endpoint.HasPageableHelper.Should().BeTrue();
        endpoint.PageableMetadata.Style.Should().Be(PageableStyle.Offset);
        endpoint.PageableMetadata.PageParameterName.Should().Be("pageNumber");
        endpoint.PageableMetadata.ItemsPropertyName.Should().Be("ChatGroupsPage");

        var source = Sources.Method(endpoint).Text;
        source.Should().Contain("ListChatGroupsAutoPagingAsync(");
        source.Should().Contain("AutoSDKPager.OffsetAsync<");
        source.Should().Contain("extractItems: static __response => __response is null");
        source.Should().Contain("(global::System.Collections.Generic.IEnumerable<global::G.ReturnChatGroup>?)__response.ChatGroupsPage");
        source.Should().Contain("initialPage: pageNumber ?? 1");
    }

    [TestMethod]
    public void AutoPaging_CursorShape_EmitsAutoPagingCompanionUsingCursorAsync()
    {
        // OpenAI-style shape: `after` cursor query parameter plus a response with a
        // `last_id`/`next_cursor` field and a single array property.
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: PageableCursor
                              version: 1.0.0
                            paths:
                              /assistants:
                                get:
                                  operationId: listAssistants
                                  parameters:
                                    - in: query
                                      name: after
                                      schema:
                                        type: string
                                    - in: query
                                      name: limit
                                      schema:
                                        type: integer
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/ListAssistantsResponse'
                            components:
                              schemas:
                                ListAssistantsResponse:
                                  type: object
                                  required: [data]
                                  properties:
                                    data:
                                      type: array
                                      items:
                                        $ref: '#/components/schemas/Assistant'
                                    next_cursor:
                                      type: string
                                Assistant:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                            """;

        var settings = DefaultSettings with { GeneratePageableHelpers = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var endpoint = data.Methods.Single(m => m.NotAsyncMethodName == "ListAssistants");

        endpoint.HasPageableHelper.Should().BeTrue();
        endpoint.PageableMetadata.Style.Should().Be(PageableStyle.Cursor);
        endpoint.PageableMetadata.PageParameterName.Should().Be("after");
        endpoint.PageableMetadata.ItemsPropertyName.Should().Be("Data");
        endpoint.PageableMetadata.NextCursorPropertyName.Should().Be("NextCursor");

        var source = Sources.Method(endpoint).Text;
        source.Should().Contain("ListAssistantsAutoPagingAsync(");
        source.Should().Contain("AutoSDKPager.CursorAsync<");
        source.Should().Contain("fetchPage: (__cursor, __ct) => ListAssistantsAsync(");
        source.Should().Contain("extractNextCursor: static __response => __response is null ? null : __response.NextCursor");
        source.Should().Contain("initialCursor: after");
        source.Should().Contain("string? after = null,");
    }

    [TestMethod]
    public void AutoPaging_OffsetShapeWithHasMore_WiresHasMorePredicateIntoOffsetAsync()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OffsetHasMore
                              version: 1.0.0
                            paths:
                              /messages:
                                get:
                                  operationId: listMessages
                                  parameters:
                                    - in: query
                                      name: page
                                      schema:
                                        type: integer
                                  responses:
                                    '200':
                                      description: OK
                                      content:
                                        application/json:
                                          schema:
                                            $ref: '#/components/schemas/ListMessagesResponse'
                            components:
                              schemas:
                                ListMessagesResponse:
                                  type: object
                                  required: [items]
                                  properties:
                                    items:
                                      type: array
                                      items:
                                        $ref: '#/components/schemas/Message'
                                    has_more:
                                      type: boolean
                                Message:
                                  type: object
                                  properties:
                                    id:
                                      type: string
                            """;

        var settings = DefaultSettings with { GeneratePageableHelpers = true };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var endpoint = data.Methods.Single(m => m.NotAsyncMethodName == "ListMessages");

        endpoint.PageableMetadata.Style.Should().Be(PageableStyle.Offset);
        endpoint.PageableMetadata.HasMorePropertyName.Should().Be("HasMore");

        var source = Sources.Method(endpoint).Text;
        source.Should().Contain("hasMore: static __response => __response is not null && (__response.HasMore ?? false)");
    }

    [TestMethod]
    public void GeneratePromptTemplateHelpers_NamesDtosWithAutoSDKPrefixToAvoidProviderCollisions()
    {
        var settings = (CSharpSettings)DefaultSettings;
        var source = Sources.GeneratePromptTemplateHelpers(settings, "PromptTemplateManager");

        // DTOs prefixed with AutoSDK so they cannot collide with provider-defined
        // PromptTemplate / PromptTemplateRequest / etc. models. See #310.
        source.Should().Contain("public sealed class AutoSDKPromptTemplate");
        source.Should().Contain("public sealed class AutoSDKPromptTemplateRequest");
        source.Should().Contain("public sealed class AutoSDKPromptTemplateMessage");
        source.Should().Contain("public sealed class AutoSDKPromptTemplateRenderException");

        // The configurable helper class name itself stays unprefixed.
        source.Should().Contain("public sealed class PromptTemplateManager");

        // No bare PromptTemplate / PromptTemplateRequest types are emitted anywhere.
        source.Should().NotContain("public sealed class PromptTemplate ");
        source.Should().NotContain("public sealed class PromptTemplateRequest");
        source.Should().NotContain("public sealed class PromptTemplateMessage");
    }

    [TestMethod]
    public void GenerateHelperFiles_SuppressXmlDocCS1591()
    {
        var settings = (CSharpSettings)DefaultSettings;
        var sources = new[]
        {
            Sources.GenerateCloudSigningHelpers(settings, "CloudRequestSigner"),
            Sources.GenerateDynamicMultipartHelpers(settings, "DynamicMultipart"),
            Sources.GenerateEvaluationWorkflowHelpers(settings, "DatasetEvaluationRunner"),
            Sources.GenerateObservabilityLifecycleHelpers(settings, "ObservabilityLifecycle"),
            Sources.GeneratePredictionWorkflowHelpers(settings, "PredictionWorkflowRunner"),
            Sources.GeneratePromptTemplateHelpers(settings, "PromptTemplateManager"),
            Sources.GenerateWebhookVerifier(settings, "WebhookVerifier"),
        };

        foreach (var source in sources)
        {
            source.Should().Contain("#pragma warning disable CS1591");
        }
    }

    [TestMethod]
    public void GenerateMethod_StampsAuthorizationOverride_OnXCallScopedAuthVendorExtension()
    {
        // Both operations share the SAME security scheme as the document default —
        // structural detection alone would NOT flag either as call-scoped. The
        // operation marked with `x-call-scoped-auth: true` opts into the marker
        // explicitly because the spec model can't express that this endpoint
        // expects a different runtime credential than its sibling.
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: VendorExtensionAuth
                              version: 1.0.0
                            paths:
                              /default-auth:
                                get:
                                  operationId: getWithDefaultAuth
                                  responses:
                                    '200':
                                      description: ok
                              /session-consume:
                                post:
                                  operationId: consumeWithSessionAuth
                                  x-call-scoped-auth: true
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              securitySchemes:
                                accountKey:
                                  type: http
                                  scheme: bearer
                            security:
                              - accountKey: []
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), DefaultSettings));
        var defaultOp = data.Methods.Single(m => m.NotAsyncMethodName == "GetWithDefaultAuth");
        var optInOp = data.Methods.Single(m => m.NotAsyncMethodName == "ConsumeWithSessionAuth");

        defaultOp.HasCallScopedSecurity.Should().BeFalse("the operation inherits document-level security and has no vendor extension");
        optInOp.HasCallScopedSecurity.Should().BeTrue("the operation declares `x-call-scoped-auth: true` even though its security matches the document default");

        var defaultSource = Sources.Method(defaultOp).Text;
        var optInSource = Sources.Method(optInOp).Text;

        defaultSource.Should().NotContain("AutoSDKHttpRequestOptions.StampAuthorizationOverride");
        optInSource.Should().Contain("AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);");
    }

    [TestMethod]
    public void GenerateMethod_StampsAuthorizationOverride_OnPerOperationSecurityOverride()
    {
        // Document-level security uses one scheme; one operation inherits it (no
        // `security` block), the other overrides it with a different scheme. The
        // overriding op should get the AutoSDKHttpRequestOptions.StampAuthorizationOverride
        // call inside its __CreateHttpRequest body; the inheriting op should not.
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: PerOpSecurity
                              version: 1.0.0
                            paths:
                              /default-auth:
                                get:
                                  operationId: getWithDefaultAuth
                                  responses:
                                    '200':
                                      description: ok
                              /session-auth:
                                post:
                                  operationId: consumeWithSessionAuth
                                  security:
                                    - sessionToken: []
                                  responses:
                                    '200':
                                      description: ok
                            components:
                              securitySchemes:
                                accountKey:
                                  type: http
                                  scheme: bearer
                                sessionToken:
                                  type: http
                                  scheme: bearer
                            security:
                              - accountKey: []
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, DefaultSettings), DefaultSettings));
        var defaultOp = data.Methods.Single(m => m.NotAsyncMethodName == "GetWithDefaultAuth");
        var overrideOp = data.Methods.Single(m => m.NotAsyncMethodName == "ConsumeWithSessionAuth");

        defaultOp.HasCallScopedSecurity.Should().BeFalse("the operation inherits document-level security");
        overrideOp.HasCallScopedSecurity.Should().BeTrue("the operation declares its own `security` block");

        var defaultSource = Sources.Method(defaultOp).Text;
        var overrideSource = Sources.Method(overrideOp).Text;

        defaultSource.Should().NotContain("AutoSDKHttpRequestOptions.StampAuthorizationOverride");
        overrideSource.Should().Contain("AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);");
    }

    [TestMethod]
    public void GenerateOptionsSupport_EmitsAuthorizationOverrideMarkerAndStampingHelper()
    {
        var supportSource = Sources.OptionsSupport(DefaultSettings).Text;

        // Marker key surface for #321.
        supportSource.Should().Contain("public static class AutoSDKHttpRequestOptions");
        supportSource.Should().Contain("public const string AuthorizationOverrideKey = \"AutoSDK.AuthorizationOverride\";");
        supportSource.Should().Contain("public static readonly global::System.Net.Http.HttpRequestOptionsKey<bool> AuthorizationOverride");
        supportSource.Should().Contain("public static void StampAuthorizationOverride(");
        supportSource.Should().Contain("public static bool HasAuthorizationOverride(");

        // Multi-target storage: HttpRequestMessage.Options on NET5+, Properties bag below.
        supportSource.Should().Contain("#if NET5_0_OR_GREATER");
        supportSource.Should().Contain("request.Options.Set(AuthorizationOverride, true);");
        supportSource.Should().Contain("request.Properties[AuthorizationOverrideKey] = true;");
    }

    [TestMethod]
    public void GenerateOptionsSupport_AuthorizationProviderHook_StampsOverrideMarkerOnCallScopedPaths()
    {
        var supportSource = Sources.OptionsSupport(DefaultSettings).Text;

        // Per-request RequestOptions.Authorizations path stamps the marker.
        supportSource.Should().Contain("if (perRequest != null && perRequest.Count > 0)");
        var perRequestBlock = supportSource.Substring(
            supportSource.IndexOf("if (perRequest != null && perRequest.Count > 0)", System.StringComparison.Ordinal));
        perRequestBlock.Should().Contain("AutoSDKHttpRequestOptions.StampAuthorizationOverride(context.Request);");

        // Provider path also stamps after applying.
        var providerBlock = supportSource.Substring(
            supportSource.IndexOf("var provider = context.ClientOptions?.AuthorizationProvider;", System.StringComparison.Ordinal));
        providerBlock.Should().Contain("ApplyAuthorization(context.Request, resolved[index]);");
        providerBlock.Should().Contain("AutoSDKHttpRequestOptions.StampAuthorizationOverride(context.Request);");

        // Stamping happens exactly twice: once per precedence path. The constructor-time
        // Authorizations fallback (handled by the per-method __authorizations resolver, not
        // this hook) should remain unstamped so rotation handlers may overwrite the account
        // default.
        var stampCount = System.Text.RegularExpressions.Regex.Matches(
            supportSource,
            @"AutoSDKHttpRequestOptions\.StampAuthorizationOverride").Count;
        stampCount.Should().Be(2);
    }

    [TestMethod]
    public void GenerateOptionsSupport_AuthorizationProviderHook_PrefersPerRequestAuthorizations()
    {
        var supportSource = Sources.OptionsSupport(DefaultSettings).Text;

        // Per-request slot exists on AutoSDKRequestOptions.
        supportSource.Should().Contain("Authorizations { get; set; }");
        supportSource.Should().Contain("global::System.Collections.Generic.IReadOnlyList<global::G.AutoSDKAuthorizationValue>? Authorizations");

        // Hook reads per-request override before falling back to the client-level provider.
        supportSource.Should().Contain("var perRequest = context.RequestOptions?.Authorizations;");
        supportSource.Should().Contain("if (perRequest != null && perRequest.Count > 0)");
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
        supportSource.Should().Contain("NextJitterSample()");
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
    public void GenerateDependencyInjection_EmitsAuthorizationProviderRegistrationHelpers()
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
                                            type: array
                                            items:
                                              type: object
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

        // Typed registration helper.
        source.Should().Contain("public static IServiceCollection AddIXSocialClientAuthorizationProvider<TProvider>(");
        source.Should().Contain("where TProvider : class, global::IXSocial.IAutoSDKAuthorizationProvider");

        // Delegate-style registration helper.
        source.Should().Contain("public static IServiceCollection AddIXSocialClientAuthorizationProvider(");
        source.Should().Contain("global::System.Func<global::System.IServiceProvider, global::IXSocial.AutoSDKHookContext,");

        // Backing delegate provider type.
        source.Should().Contain("internal sealed class IXSocialClientDelegateAuthorizationProvider");

        // The Register method auto-resolves any registered provider via DI.
        source.Should().Contain("var authorizationProvider = (global::IXSocial.IAutoSDKAuthorizationProvider?)");
        source.Should().Contain("clientOptions.UseAuthorizationProvider(authorizationProvider)");
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
