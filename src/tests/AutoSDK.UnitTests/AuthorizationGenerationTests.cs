using System.Collections.Immutable;
using AutoSDK.Generation;
using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

[TestClass]
public class AuthorizationGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        TargetFramework = "netstandard2.0",
        Namespace = "G",
        ClassName = "Api",
    };

    [TestMethod]
    public void Prepare_DeduplicatesTopLevelAuthorizations_WithSameFriendlyName()
    {
        const string yaml = """
                            openapi: 3.0.1
                            info:
                              title: DuplicateAuth
                              version: 1.0.0
                            security:
                              - bearerA: []
                              - bearerB: []
                            paths:
                              /ping:
                                get:
                                  operationId: ping
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                bearerA:
                                  type: http
                                  scheme: bearer
                                bearerB:
                                  type: http
                                  scheme: bearer
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
            GroupByTags = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        data.Authorizations.Should().HaveCount(1);
        data.Authorizations[0].FriendlyName.Should().Be("Bearer");
        data.Authorizations.Select(x => Sources.Authorization(x).Name).Should().OnlyHaveUniqueItems();
    }

    [TestMethod]
    public void GenerateAuthorization_WithHyphenatedSchemeName_SanitizesFriendlyName()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Hyphenated Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - access-token: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                access-token:
                                  type: http
                                  scheme: access-token
                            """;

        var authorization = GetSingleAuthorization(yaml);

        authorization.FriendlyName.Should().Be("AccessToken");
        authorization.MethodName.Should().Be("AuthorizeUsingAccessToken");
        Sources.Authorization(authorization).Name.Should().Contain(".AccessToken.g.cs");
        Sources.AuthorizationInterface(authorization).Name.Should().Contain(".AccessToken.g.cs");
    }

    [TestMethod]
    public void GenerateAuthorization_ApiKeyInCookie_UsesApiKeyParameter()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Cookie Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - access-token: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                access-token:
                                  type: apiKey
                                  in: cookie
                                  name: access-token
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var content = Sources.Authorization(authorization).Text;

        authorization.FriendlyName.Should().Be("ApiKeyInCookie");
        authorization.MethodName.Should().Be("AuthorizeUsingApiKeyInCookie");
        authorization.Parameters.Should().ContainSingle().Which.Should().Be("apiKey");
        content.Should().Contain("public void AuthorizeUsingApiKeyInCookie(");
        content.Should().Contain("string apiKey");
        content.Should().Contain("Location = \"Cookie\"");
        content.Should().Contain("Name = \"access-token\"");
        content.Should().Contain("Value = apiKey");
    }

    [TestMethod]
    public void GenerateAuthorization_OpenIdConnect_EmitsDiscoveryUrlAndBearerHelpers()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OIDC Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - oidc: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                oidc:
                                  type: openIdConnect
                                  openIdConnectUrl: https://example.com/.well-known/openid-configuration
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var content = Sources.Authorization(authorization).Text;
        var interfaceContent = Sources.AuthorizationInterface(authorization).Text;

        authorization.FriendlyName.Should().Be("OpenIdConnect");
        authorization.SchemeId.Should().Be("Oidc");
        authorization.OpenIdConnectUrl.Should().Be("https://example.com/.well-known/openid-configuration");
        content.Should().Contain("public string OpenIdConnectDiscoveryUrl => \"https://example.com/.well-known/openid-configuration\"");
        content.Should().Contain("public void AuthorizeUsingOpenIdConnect(");
        content.Should().Contain("AuthorizeUsingOpenIdConnect(accessToken, \"Bearer\")");
        content.Should().Contain("Type = \"OpenIdConnect\"");
        content.Should().Contain("SchemeId = \"Oidc\"");
        content.Should().Contain("Location = \"Header\"");
        content.Should().Contain("Name = tokenType");
        interfaceContent.Should().Contain("public string OpenIdConnectDiscoveryUrl { get; }");
    }

    [TestMethod]
    public void GenerateAuthorization_MutualTls_EmitsMarkerAndCertificateHelpers()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: mTLS Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - mtlsAuth: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                mtlsAuth:
                                  type: mutualTLS
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var content = Sources.Authorization(authorization).Text;
        var interfaceContent = Sources.AuthorizationInterface(authorization).Text;

        authorization.FriendlyName.Should().Be("MutualTls");
        authorization.SchemeId.Should().Be("MtlsAuth");
        content.Should().Contain("public void AuthorizeUsingMutualTls()");
        content.Should().Contain("Type = \"MutualTLS\"");
        content.Should().Contain("SchemeId = \"MtlsAuth\"");
        content.Should().Contain("public void ConfigureMutualTlsClientCertificate(");
        content.Should().Contain("ClientCertificateOption.Manual");
        interfaceContent.Should().Contain("public void ConfigureMutualTlsClientCertificate(");
    }

    [TestMethod]
    public void GenerateAuthorization_ReplacesOnlyMatchingScheme()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Header Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - access-token: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                access-token:
                                  type: apiKey
                                  in: header
                                  name: access-token
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var content = Sources.Authorization(authorization).Text;

        content.Should().NotContain("Authorizations.Clear();");
        content.Should().Contain("for (var i = Authorizations.Count - 1; i >= 0; i--)");
        content.Should().Contain("__authorization.Type == \"ApiKey\"");
        content.Should().Contain("__authorization.Location == \"Header\"");
        content.Should().Contain("__authorization.Name == \"access-token\"");
    }

    [TestMethod]
    public void Prepare_PreservesDistinctApiKeyRequirements_ForAndSemantics()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Composite Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - apiKeyAuth: []
                                      appIdAuth: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                apiKeyAuth:
                                  type: apiKey
                                  in: header
                                  name: X-API-Key
                                appIdAuth:
                                  type: apiKey
                                  in: header
                                  name: X-App-Id
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };
        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        data.Authorizations.Select(x => x.FriendlyName)
            .Should()
            .Equal("ApiKeyAuth", "AppIdAuth");

        var endPoint = data.Methods.Should().ContainSingle().Subject;
        endPoint.AuthorizationRequirements.Should().ContainSingle();
        endPoint.AuthorizationRequirements[0].Authorizations.Select(x => x.FriendlyName)
            .Should()
            .Equal("ApiKeyAuth", "AppIdAuth");

        var methodSource = Sources.Method(endPoint).Text;
        methodSource.Should().Contain("EndPointSecurityResolver.ResolveAuthorizations");
        methodSource.Should().Contain("foreach (var __authorization in __authorizations)");
    }

    [TestMethod]
    public void Prepare_ExplicitEmptyOperationSecurity_DoesNotInheritDocumentRequirements()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Public Ping
                              version: 1.0.0
                            security:
                              - bearerAuth: []
                            paths:
                              /ping:
                                get:
                                  operationId: getPing
                                  security: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                bearerAuth:
                                  type: http
                                  scheme: bearer
                            """;

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)DefaultSettings), (CSharpSettings)DefaultSettings));
        var endPoint = data.Methods.Should().ContainSingle().Subject;

        endPoint.Authorizations.Should().BeEmpty();
        endPoint.AuthorizationRequirements.Should().BeEmpty();

        var methodSource = Sources.Method(endPoint).Text;
        methodSource.Should().NotContain("EndPointSecurityResolver.ResolveAuthorizations");
        methodSource.Should().NotContain("AutoSDKOAuth2Helpers.SendAsync");
        methodSource.Should().NotContain("foreach (var __authorization in");
    }

    [TestMethod]
    public void GenerateAuthorization_OAuth2AuthorizationCode_GeneratesAuthorizationCodeHelpers()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OAuth2 Authorization Code
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    authorizationCode:
                                      authorizationUrl: https://example.com/oauth/authorize
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                                        write: Write access
                            """;

        var authorization = GetSingleAuthorization(yaml);

        authorization.FriendlyName.Should().Be("OAuth2");
        authorization.Flows.Should().ContainSingle();
        authorization.Flows[0].Type.Should().Be(nameof(OpenApiOAuthFlows.AuthorizationCode));

        var content = Sources.Authorization(authorization).Text;
        var interfaceContent = Sources.AuthorizationInterface(authorization).Text;

        content.Should().Contain("public sealed class OAuth2Token");
        content.Should().Contain("public interface IOAuth2TokenStore");
        content.Should().Contain("public sealed class AutoSDKOAuth2Coordinator");
        content.Should().Contain("public enum OAuth2Scope");
        content.Should().Contain("public bool AutoRefreshOAuth2Tokens");
        content.Should().Contain("public global::System.TimeSpan OAuth2RefreshClockSkew");
        content.Should().Contain("public void ConfigureOAuth2TokenRefresh(");
        content.Should().Contain("public OAuth2Token? GetOAuth2Token()");
        content.Should().Contain("public void ClearOAuth2Token()");
        content.Should().Contain("public void AuthorizeUsingOAuth2(");
        content.Should().Contain("public void AuthorizeUsingOAuth2(");
        content.Should().Contain("OAuth2Token token");
        content.Should().Contain("public string GetOAuth2AuthorizationUrl(");
        content.Should().Contain("https://example.com/oauth/authorize");
        content.Should().Contain("public async global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2CodeForTokenAsync(");
        content.Should().Contain("\"grant_type\", \"authorization_code\"");
        content.Should().Contain("\"code_verifier\", codeVerifier");
        content.Should().Contain("https://example.com/oauth/token");
        content.Should().Contain("public async global::System.Threading.Tasks.Task<OAuth2Token> RefreshOAuth2TokenAsync(");
        content.Should().Contain("\"grant_type\", \"refresh_token\"");
        content.Should().Contain("CreateOAuth2PkceCodeVerifier");
        content.Should().Contain("CreateOAuth2PkceCodeChallenge");
        content.Should().Contain("public async global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(");
        content.Should().Contain("public string GetOAuth2AuthorizationUrl(");
        content.Should().Contain("global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes");

        interfaceContent.Should().Contain("public global::G.Api.IOAuth2TokenStore OAuth2TokenStore { get; set; }");
        interfaceContent.Should().Contain("public bool AutoRefreshOAuth2Tokens { get; set; }");
        interfaceContent.Should().Contain("public global::System.TimeSpan OAuth2RefreshClockSkew { get; set; }");
        interfaceContent.Should().Contain("public void ConfigureOAuth2TokenRefresh(");
        interfaceContent.Should().Contain("public global::G.Api.OAuth2Token? GetOAuth2Token();");
        interfaceContent.Should().Contain("public void ClearOAuth2Token();");
        interfaceContent.Should().Contain("public void AuthorizeUsingOAuth2(");
        interfaceContent.Should().Contain("public void AuthorizeUsingOAuth2(");
        interfaceContent.Should().Contain("global::G.Api.OAuth2Token token");
        interfaceContent.Should().Contain("public string GetOAuth2AuthorizationUrl(");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token> ExchangeOAuth2CodeForTokenAsync(");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token> RefreshOAuth2TokenAsync(");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithAuthorizationCodeAsync(");
    }

    [TestMethod]
    public void GenerateMainAuthorizationConstructor_OAuth2_UsesAccessTokenConvenienceConstructor()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OAuth2 Constructor
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    clientCredentials:
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var constructor = Sources.MainAuthorizationConstructor(ImmutableArray.Create(authorization).AsEquatableArray());

        constructor.Name.Should().Be("G.Api.Constructors.OAuth2.g.cs");
        constructor.Text.Should().Contain("string accessToken,");
        constructor.Text.Should().Contain("AuthorizeUsingOAuth2(accessToken);");
        constructor.Text.Should().Contain("ref string accessToken");
    }

    [TestMethod]
    public void GenerateAuthorization_OAuth2ClientCredentials_UsesFlowTokenUrl()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OAuth2 Client Credentials
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    clientCredentials:
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                            """;

        var authorization = GetSingleAuthorization(yaml);
        var content = Sources.Authorization(authorization).Text;

        authorization.Flows.Should().ContainSingle();
        authorization.Flows[0].Type.Should().Be(nameof(OpenApiOAuthFlows.ClientCredentials));
        content.Should().Contain("https://example.com/oauth/token");
        content.Should().NotContain("AutoSDK.Models.EquatableArray");
        content.Should().Contain("public enum OAuth2Scope");
        content.Should().Contain("global::System.Collections.Generic.IEnumerable<OAuth2Scope>? scopes = null");
        content.Should().Contain("string? scope = null");
        content.Should().Contain("ConfigureOAuth2TokenRefresh(");
        content.Should().Contain("public async global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithCredentialsAsync(");
    }

    [TestMethod]
    public void GenerateAuthorization_OpenApi32OAuthDeviceAuthorization_PreservesMetadataAndGeneratesHelpers()
    {
        const string yaml = """
                            openapi: 3.2.0
                            info:
                              title: OAuth2 Device Authorization
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - OAuth2: [read, write]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  oauth2MetadataUrl: https://example.com/.well-known/oauth-authorization-server
                                  deprecated: true
                                  flows:
                                    deviceAuthorization:
                                      deviceAuthorizationUrl: https://example.com/oauth/device
                                      tokenUrl: https://example.com/oauth/token
                                      refreshUrl: https://example.com/oauth/refresh
                                      scopes:
                                        read: Read access
                                        write: Write access
                            """;

        var authorization = GetSingleAuthorization(yaml);

        authorization.IsDeprecated.Should().BeTrue();
        authorization.OAuth2MetadataUrl.Should().Be("https://example.com/.well-known/oauth-authorization-server");
        authorization.Flows.Should().ContainSingle();
        authorization.Flows[0].Type.Should().Be(nameof(OpenApiOAuthFlows.DeviceAuthorization));
        authorization.Flows[0].DeviceAuthorizationUrl.Should().Be("https://example.com/oauth/device");

        var content = Sources.Authorization(authorization).Text;
        var interfaceContent = Sources.AuthorizationInterface(authorization).Text;

        content.Should().Contain("public string? OAuth2MetadataUrl");
        content.Should().Contain("https://example.com/.well-known/oauth-authorization-server");
        content.Should().Contain("public bool IsOAuth2Deprecated => true;");
        content.Should().Contain("[global::System.Obsolete(\"This security scheme marked as deprecated.\")]");
        content.Should().Contain("public sealed class OAuth2DeviceAuthorizationResponse");
        content.Should().Contain("public global::System.Threading.Tasks.Task<OAuth2DeviceAuthorizationResponse> RequestOAuth2DeviceAuthorizationAsync(");
        content.Should().Contain("https://example.com/oauth/device");
        content.Should().Contain("public global::System.Threading.Tasks.Task<OAuth2Token> ExchangeOAuth2DeviceCodeForTokenAsync(");
        content.Should().Contain("\"urn:ietf:params:oauth:grant-type:device_code\"");
        content.Should().Contain("public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithDeviceAuthorizationAsync(");

        interfaceContent.Should().Contain("public string? OAuth2MetadataUrl { get; }");
        interfaceContent.Should().Contain("public bool IsOAuth2Deprecated { get; }");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task<global::G.Api.OAuth2DeviceAuthorizationResponse> RequestOAuth2DeviceAuthorizationAsync(");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task<global::G.Api.OAuth2Token> ExchangeOAuth2DeviceCodeForTokenAsync(");
        interfaceContent.Should().Contain("public global::System.Threading.Tasks.Task AuthorizeUsingOAuth2WithDeviceAuthorizationAsync(");
    }

    [TestMethod]
    public void Prepare_WithOperationLevelOAuth2_GeneratesSharedOAuth2Support()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: Operation OAuth2
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  tags: [orders]
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    authorizationCode:
                                      authorizationUrl: https://example.com/oauth/authorize
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
            GroupByTags = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));

        data.Authorizations.Should().ContainSingle(x => x.Type == SecuritySchemeType.OAuth2);
        data.Clients.Should().ContainSingle(x => x.Id == "MainConstructor" && x.HasOAuth2Support);
    }

    [TestMethod]
    public void Prepare_WithMutualTls_GeneratesOwnedHttpClientHandlerSupport()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: mTLS Auth
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - mtlsAuth: []
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                mtlsAuth:
                                  type: mutualTLS
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var mainClient = data.Clients.Should().ContainSingle(x => x.Id == "MainConstructor").Subject;

        mainClient.HasMutualTlsSupport.Should().BeTrue();
        var content = Sources.Client(mainClient).Text;
        content.Should().Contain("private readonly global::System.Net.Http.HttpClientHandler? _ownedHttpClientHandler;");
        content.Should().Contain("_ownedHttpClientHandler = new global::System.Net.Http.HttpClientHandler();");
    }

    [TestMethod]
    public void GenerateClient_WithOAuth2Support_SharesCoordinatorWithSubclients()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OAuth2 Tagged API
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  tags: [orders]
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                              /users:
                                get:
                                  operationId: getUsers
                                  tags: [users]
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    authorizationCode:
                                      authorizationUrl: https://example.com/oauth/authorize
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var mainClient = data.Clients.Single(x => x.Id == "MainConstructor");
        var content = Sources.Client(mainClient).Text;

        mainClient.HasOAuth2Support.Should().BeTrue();
        content.Should().Contain("internal global::G.Api.AutoSDKOAuth2Coordinator AutoSDKOAuth2State { get; set; } = new global::G.Api.AutoSDKOAuth2Coordinator();");
        content.Should().Contain("AutoSDKOAuth2State = AutoSDKOAuth2State,");
    }

    [TestMethod]
    public void GenerateMethod_WithOAuth2Authorization_UsesSharedSendHelper()
    {
        const string yaml = """
                            openapi: 3.0.3
                            info:
                              title: OAuth2 Methods
                              version: 1.0.0
                            paths:
                              /orders:
                                get:
                                  operationId: getOrders
                                  security:
                                    - OAuth2: [read]
                                  responses:
                                    '200':
                                      description: OK
                            components:
                              securitySchemes:
                                OAuth2:
                                  type: oauth2
                                  flows:
                                    authorizationCode:
                                      authorizationUrl: https://example.com/oauth/authorize
                                      tokenUrl: https://example.com/oauth/token
                                      scopes:
                                        read: Read access
                            """;

        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, (CSharpSettings)settings), (CSharpSettings)settings));
        var method = data.Methods.Single();
        var content = Sources.Method(method).Text;

        content.Should().Contain("global::G.Api.AutoSDKOAuth2Helpers.SendAsync(");
        content.Should().Contain("oAuth2Coordinator: AutoSDKOAuth2State");
    }

    private static Authorization GetSingleAuthorization(string yaml)
    {
        var settings = DefaultSettings with
        {
            GenerateSdk = true,
            GenerateConstructors = true,
        };

        var document = yaml.GetOpenApiDocument(settings);
        var operation = document.Paths["/orders"]!.Operations![System.Net.Http.HttpMethod.Get];

        return operation.Security!
            .SelectMany(x => x)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                x.Key, settings, settings))
            .Single();
    }
}
