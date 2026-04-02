using System.Collections.Immutable;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Models;
using Microsoft.OpenApi;

namespace AutoSDK.UnitTests;

public partial class Tests
{
    [TestMethod]
    public void InjectSecuritySchemes_ApiKeyHeader_ResolvesViaReference()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>(),
            },
            Security = new List<OpenApiSecurityRequirement>(),
        };
        var settings = Settings.Default with
        {
            SecuritySchemes = new[] { "ApiKey:Header:xi-api-key" }.ToImmutableArray(),
        };

        // Act
        document.InjectSecuritySchemes(settings);

        // Assert — reference resolution must work (the core bug from #146)
        document.Security.Should().HaveCount(1);
        var requirement = document.Security[0];
        var schemeRef = requirement.Keys.First();
        schemeRef.Type.Should().Be(SecuritySchemeType.ApiKey);
        schemeRef.In.Should().Be(ParameterLocation.Header);
        schemeRef.Name.Should().Be("xi-api-key");
    }

    [TestMethod]
    public void InjectSecuritySchemes_HttpBearer_ResolvesViaReference()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>(),
            },
            Security = new List<OpenApiSecurityRequirement>(),
        };
        var settings = Settings.Default with
        {
            SecuritySchemes = new[] { "Http:Header:Bearer" }.ToImmutableArray(),
        };

        // Act
        document.InjectSecuritySchemes(settings);

        // Assert
        document.Security.Should().HaveCount(1);
        var schemeRef = document.Security[0].Keys.First();
        schemeRef.Type.Should().Be(SecuritySchemeType.Http);
        schemeRef.Scheme.Should().Be("Bearer");
    }

    [TestMethod]
    public void InjectSecuritySchemes_ApiKey_ProducesCorrectAuthorization()
    {
        // Arrange — use a fully parsed document to get workspace support
        var yaml = @"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
      responses:
        '200':
          description: OK
";
        var settings = Settings.Default with
        {
            SecuritySchemes = new[] { "ApiKey:Header:xi-api-key" }.ToImmutableArray(),
        };

        // Act — parse then verify the authorization roundtrip
        var document = yaml.GetOpenApiDocument(settings);
        var authorizations = document.Security!
            .SelectMany(r => r)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                x.Key, settings, settings))
            .ToArray();

        // Assert
        authorizations.Should().HaveCount(1);
        var auth = authorizations[0];
        auth.Type.Should().Be(SecuritySchemeType.ApiKey);
        auth.In.Should().Be(ParameterLocation.Header);
        auth.Name.Should().Be("xi-api-key");
        auth.FriendlyName.Should().Be("ApiKeyInHeader");
        auth.Parameters.Should().ContainSingle().Which.Should().Be("apiKey");
    }

    [TestMethod]
    public void InjectSecuritySchemes_HttpCustomScheme_ProducesCorrectAuthorization()
    {
        var yaml = @"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
      responses:
        '200':
          description: OK
";
        var settings = Settings.Default with
        {
            Namespace = "Deepgram",
            ClassName = "DeepgramClient",
            SecuritySchemes = new[] { "Http:Header:Token" }.ToImmutableArray(),
        };

        var document = yaml.GetOpenApiDocument(settings);
        var auth = document.Security!
            .SelectMany(r => r)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                x.Key, settings, settings))
            .Single();

        auth.Type.Should().Be(SecuritySchemeType.Http);
        auth.In.Should().Be(ParameterLocation.Header);
        auth.Scheme.Should().Be("Token");
        auth.FriendlyName.Should().Be("Token");
        auth.Parameters.Should().ContainSingle().Which.Should().Be("apiKey");

        var source = Sources.Authorization(auth);
        source.Name.Should().Be("Deepgram.DeepgramClient.Authorizations.Token.g.cs");
        source.Text.Should().Contain("Name = \"Token\"");
        source.Text.Should().Contain("Value = apiKey");
    }

    [TestMethod]
    public void InjectSecuritySchemes_ApiKeyHeader_MainAuthorizationConstructor_UsesFriendlyNameInFileName()
    {
        // Arrange
        var yaml = @"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
      responses:
        '200':
          description: OK
";
        var settings = Settings.Default with
        {
            Namespace = "Qdrant",
            ClassName = "QdrantClient",
            SecuritySchemes = new[] { "ApiKey:Header:api-key" }.ToImmutableArray(),
        };

        var document = yaml.GetOpenApiDocument(settings);
        var authorizations = document.Security!
            .SelectMany(x => x)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                x.Key, settings, settings))
            .ToImmutableArray()
            .AsEquatableArray();

        // Act
        var file = Sources.MainAuthorizationConstructor(authorizations);

        // Assert
        file.Name.Should().Be("Qdrant.QdrantClient.Constructors.ApiKeyInHeader.g.cs");
    }

    [TestMethod]
    public void InjectSecuritySchemes_OpenIdConnect_UsesNonEmptyFriendlyNameInFileNames()
    {
        var yaml = @"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /test:
    get:
      operationId: getTest
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
";
        var settings = Settings.Default with
        {
            Namespace = "Oidc",
            ClassName = "OidcClient",
        };

        var document = yaml.GetOpenApiDocument(settings);
        var operation = document.Paths.Single().Value!.Operations!.Single().Value;
        var authorizations = operation.Security!
            .SelectMany(x => x)
            .Select(x => CSharpAuthorizationFactory.FromOpenApiSecurityScheme(
                x.Key, settings, settings))
            .ToImmutableArray()
            .AsEquatableArray();

        authorizations.Should().HaveCount(1);
        authorizations[0].FriendlyName.Should().Be("OpenIdConnect");
        authorizations[0].MethodName.Should().Be("AuthorizeUsingOpenIdConnect");
        Sources.Authorization(authorizations[0]).Name.Should().Be("Oidc.OidcClient.Authorizations.OpenIdConnect.g.cs");
        Sources.MainAuthorizationConstructor(authorizations).Name.Should().Be("Oidc.OidcClient.Constructors.OpenIdConnect.g.cs");
    }

    [TestMethod]
    public void InjectSecuritySchemes_InvalidFormat_Skips()
    {
        // Arrange
        var document = new OpenApiDocument
        {
            Components = new OpenApiComponents
            {
                SecuritySchemes = new Dictionary<string, IOpenApiSecurityScheme>(),
            },
            Security = new List<OpenApiSecurityRequirement>(),
        };
        var settings = Settings.Default with
        {
            SecuritySchemes = new[] { "InvalidFormat" }.ToImmutableArray(),
        };

        // Act
        document.InjectSecuritySchemes(settings);

        // Assert
        document.Security.Should().BeEmpty();
    }

    [TestMethod]
    public void InjectSecuritySchemes_ReplacesOperationSecurity_AndSuppressesMatchingParameters()
    {
        var yaml = """
openapi: 3.0.3
info:
  title: Auth Operation Security
  version: 1.0.0
components:
  securitySchemes:
    queryKey:
      type: apiKey
      in: query
      name: api_key
paths:
  /chat:
    get:
      operationId: getChat
      security:
        - queryKey: []
      parameters:
        - in: header
          name: Authorization
          schema:
            type: string
        - in: query
          name: keep
          schema:
            type: string
      responses:
        '200':
          description: ok
""";

        var settings = Settings.Default with
        {
            SecuritySchemes = new[] { "Http:Header:Bearer" }.ToImmutableArray(),
        };

        var document = yaml.GetOpenApiDocument(settings);
        var pathItem = document.Paths["/chat"];
        pathItem.Should().NotBeNull();
        pathItem!.Operations.Should().NotBeNull();
        var operation = pathItem.Operations![System.Net.Http.HttpMethod.Get];

        document.Components!.SecuritySchemes.Should().ContainSingle();
        document.Security!.Should().ContainSingle();
        document.Security[0].Keys.Single().Scheme.Should().Be("Bearer");

        operation.Security.Should().NotBeNull();
        operation.Security!.Should().BeEmpty();
        operation.Parameters.Should().ContainSingle();
        operation.Parameters![0].Name.Should().Be("keep");
    }
}
