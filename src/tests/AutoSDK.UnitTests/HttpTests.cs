using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class HttpTests : VerifyBase
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
    };

    private static (IReadOnlyList<OperationContext> Operations, Microsoft.OpenApi.OpenApiDocument Document)
        LoadSpec(string yaml)
    {
        var settings = DefaultSettings;
        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var operations = document.GetOperations(settings, globalSettings: settings, schemas);
        return (operations, document);
    }

    #region GenerateHttpFile

    [TestMethod]
    public Task Petstore()
    {
        var yaml = TestSpecCache.GetText("petstore.yaml");
        var (operations, document) = LoadSpec(yaml);

        var files = new List<string>();

        // Environment file
        var servers = (document.Servers ?? []).ToList();
        var securitySchemes = (document.Security ?? [])
            .SelectMany(req => req.Keys)
            .GroupBy(s => s.Name ?? s.Scheme ?? "")
            .Select(g => g.First())
            .ToList();
        files.Add("=== http-client.env.json ===");
        files.Add(Sources.GenerateHttpEnvironmentFile(servers, securitySchemes));

        // Http files per tag
        foreach (var group in operations
                     .SelectMany(x => x.Tags.Select(y => (Tag: y, Operation: x)))
                     .GroupBy(x => x.Tag))
        {
            files.Add($"=== {group.Key}.http ===");
            files.Add(Sources.GenerateHttpFile(group.Key, group.Select(x => x.Operation).ToList()));
        }

        return Verify(string.Join("\n", files))
            .UseDirectory("Snapshots/Http")
            .UseFileName("petstore");
    }

    [TestMethod]
    public Task SpecialCases()
    {
        var yaml = TestSpecCache.GetText("special-cases.yaml");
        var (operations, document) = LoadSpec(yaml);

        var files = new List<string>();

        var servers = (document.Servers ?? []).ToList();
        var securitySchemes = (document.Security ?? [])
            .SelectMany(req => req.Keys)
            .GroupBy(s => s.Name ?? s.Scheme ?? "")
            .Select(g => g.First())
            .ToList();
        files.Add("=== http-client.env.json ===");
        files.Add(Sources.GenerateHttpEnvironmentFile(servers, securitySchemes));

        foreach (var group in operations
                     .SelectMany(x => x.Tags.Select(y => (Tag: y, Operation: x)))
                     .GroupBy(x => x.Tag))
        {
            files.Add($"=== {group.Key}.http ===");
            files.Add(Sources.GenerateHttpFile(group.Key, group.Select(x => x.Operation).ToList()));
        }

        return Verify(string.Join("\n", files))
            .UseDirectory("Snapshots/Http")
            .UseFileName("special-cases");
    }

    #endregion

    #region GenerateHttpRequest

    [TestMethod]
    public void GetRequest_HasQueryParams()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      summary: List items
      parameters:
        - name: limit
          in: query
          schema:
            type: integer
            default: 20
        - name: offset
          in: query
          schema:
            type: integer
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: array
                items:
                  type: string
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("GET {{host}}/items?limit=20&offset={{offset}}");
        result.Should().Contain("# @name listItems");
        result.Should().Contain("Accept: application/json");
    }

    [TestMethod]
    public void PostRequest_HasJsonBody()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    post:
      operationId: createItem
      summary: Create an item
      requestBody:
        required: true
        content:
          application/json:
            schema:
              type: object
              properties:
                name:
                  type: string
                count:
                  type: integer
      responses:
        '201':
          description: Created
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("POST {{host}}/items");
        result.Should().Contain("Content-Type: application/json");
        result.Should().Contain("\"name\": \"string\"");
        result.Should().Contain("\"count\": 0");
    }

    [TestMethod]
    public void PathParams_ConvertedToHttpVariables()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /users/{userId}/posts/{postId}:
    get:
      operationId: getPost
      parameters:
        - name: userId
          in: path
          required: true
          schema:
            type: string
        - name: postId
          in: path
          required: true
          schema:
            type: string
      responses:
        '200':
          description: OK
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("GET {{host}}/users/{{userId}}/posts/{{postId}}");
    }

    [TestMethod]
    public void HeaderParams_Emitted()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /data:
    get:
      operationId: getData
      parameters:
        - name: X-Request-Id
          in: header
          schema:
            type: string
      responses:
        '200':
          description: OK
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("X-Request-Id: {{X-Request-Id}}");
    }

    [TestMethod]
    public void DeprecatedOperation_MarkedInTitle()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /old:
    get:
      operationId: oldEndpoint
      summary: Old endpoint
      deprecated: true
      responses:
        '200':
          description: OK
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("### [DEPRECATED] Old endpoint");
    }

    [TestMethod]
    public void FernAvailabilityDeprecatedOperation_MarkedInTitle()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /old:
    get:
      operationId: oldEndpoint
      summary: Old endpoint
      x-fern-availability: deprecated
      responses:
        '200':
          description: OK
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("### [DEPRECATED] Old endpoint");
    }

    [TestMethod]
    public void BearerAuth_EmitsAuthorizationHeader()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /secure:
    get:
      operationId: getSecure
      responses:
        '200':
          description: OK
security:
  - BearerAuth: []
components:
  securitySchemes:
    BearerAuth:
      type: http
      scheme: bearer
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("Authorization: Bearer {{token}}");
    }

    [TestMethod]
    public void ApiKeyInHeader_EmitsCustomHeader()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /secure:
    get:
      operationId: getSecure
      responses:
        '200':
          description: OK
security:
  - ApiKeyAuth: []
components:
  securitySchemes:
    ApiKeyAuth:
      type: apiKey
      in: header
      name: X-API-Key
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("X-API-Key: {{api_key}}");
    }

    [TestMethod]
    public void ApiKeyInQuery_AppendedToUrl()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /secure:
    get:
      operationId: getSecure
      responses:
        '200':
          description: OK
security:
  - ApiKeyAuth: []
components:
  securitySchemes:
    ApiKeyAuth:
      type: apiKey
      in: query
      name: api_key
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("{{host}}/secure?api_key={{api_key}}");
        result.Should().NotContain("Authorization");
    }

    [TestMethod]
    public void ApiKeyInCookie_EmitsCookieHeader()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /secure:
    get:
      operationId: getSecure
      responses:
        '200':
          description: OK
security:
  - ApiKeyAuth: []
components:
  securitySchemes:
    ApiKeyAuth:
      type: apiKey
      in: cookie
      name: session
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().Contain("Cookie: session={{api_key}}");
    }

    [TestMethod]
    public void ExplicitEmptyOperationSecurity_DoesNotInheritGlobalHttpAuth()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
security:
  - BearerAuth: []
paths:
  /public:
    get:
      operationId: getPublic
      security: []
      responses:
        '200':
          description: OK
components:
  securitySchemes:
    BearerAuth:
      type: http
      scheme: bearer
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().NotContain("Authorization: Bearer {{token}}");
    }

    [TestMethod]
    public void NoRequestBody_NoContentType()
    {
        var (operations, _) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
paths:
  /items:
    get:
      operationId: listItems
      responses:
        '200':
          description: OK
");

        var result = Sources.GenerateHttpRequest(operations[0]);

        result.Should().NotContain("Content-Type");
    }

    #endregion

    #region GenerateHttpEnvironmentFile

    [TestMethod]
    public void EnvFile_SingleServer()
    {
        var (_, document) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
servers:
  - url: https://api.example.com/v1
    description: Production
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
");

        var servers = (document.Servers ?? []).ToList();
        var result = Sources.GenerateHttpEnvironmentFile(servers, []);

        result.Should().Contain("\"host\": \"https://api.example.com/v1\"");
        result.Should().Contain("\"production\"");
    }

    [TestMethod]
    public void EnvFile_MultipleServers()
    {
        var (_, document) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
servers:
  - url: https://dev.example.com
    description: Development
  - url: https://staging.example.com
    description: Staging
  - url: https://api.example.com
    description: Production
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
");

        var servers = (document.Servers ?? []).ToList();
        var result = Sources.GenerateHttpEnvironmentFile(servers, []);

        result.Should().Contain("\"development\"");
        result.Should().Contain("\"staging\"");
        result.Should().Contain("\"production\"");
    }

    [TestMethod]
    public void EnvFile_ServerVariables_UseDefaults()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Server Vars
  version: 1.0.0
servers:
  - url: https://{region}.example.com/{version}
    description: Production
    variables:
      region:
        default: us
        enum: [us, eu]
      version:
        default: v1
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
""";

        var (_, document) = LoadSpec(yaml);
        var servers = (document.Servers ?? []).ToList();
        var result = Sources.GenerateHttpEnvironmentFile(servers, []);

        result.Should().Contain("\"host\": \"https://us.example.com/v1\"");
        result.Should().NotContain("{region}");
        result.Should().NotContain("{version}");
    }

    [TestMethod]
    public void Prepare_ServerVariables_UseResolvedDefaultBaseUrl()
    {
        const string yaml = """
openapi: 3.0.3
info:
  title: Server Vars
  version: 1.0.0
servers:
  - url: https://{region}.example.com/{version}
    variables:
      region:
        default: us
        enum: [us, eu]
      version:
        default: v1
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
                properties:
                  ok:
                    type: boolean
""";

        var settings = DefaultSettings with
        {
            ClassName = "ServerVarsClient",
        };

        var data = AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));

        data.Clients.Should().ContainSingle();
        data.Clients[0].BaseUrl.Should().Be("https://us.example.com/v1");
    }

    [TestMethod]
    public void EnvFile_NoServers_DefaultsToDev()
    {
        var result = Sources.GenerateHttpEnvironmentFile([], []);

        result.Should().Contain("\"dev\"");
        result.Should().Contain("\"host\": \"http://localhost\"");
    }

    [TestMethod]
    public void EnvFile_BearerAuth_IncludesTokenVariable()
    {
        var (_, document) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
servers:
  - url: https://api.example.com
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
security:
  - BearerAuth: []
components:
  securitySchemes:
    BearerAuth:
      type: http
      scheme: bearer
");

        var servers = (document.Servers ?? []).ToList();
        var securitySchemes = (document.Security ?? [])
            .SelectMany(req => req.Keys)
            .GroupBy(s => s.Name ?? s.Scheme ?? "")
            .Select(g => g.First())
            .ToList();

        var result = Sources.GenerateHttpEnvironmentFile(servers, securitySchemes);

        result.Should().Contain("\"token\": \"\"");
    }

    [TestMethod]
    public void EnvFile_ApiKeyAuth_IncludesApiKeyVariable()
    {
        var (_, document) = LoadSpec(@"openapi: 3.0.1
info:
  title: Test
  version: 1.0.0
servers:
  - url: https://api.example.com
paths:
  /ping:
    get:
      operationId: ping
      responses:
        '200':
          description: OK
security:
  - ApiKeyAuth: []
components:
  securitySchemes:
    ApiKeyAuth:
      type: apiKey
      in: header
      name: X-API-Key
");

        var servers = (document.Servers ?? []).ToList();
        var securitySchemes = (document.Security ?? [])
            .SelectMany(req => req.Keys)
            .GroupBy(s => s.Name ?? s.Scheme ?? "")
            .Select(g => g.First())
            .ToList();

        var result = Sources.GenerateHttpEnvironmentFile(servers, securitySchemes);

        result.Should().Contain("\"api_key\": \"\"");
    }

    [TestMethod]
    public void EnvFile_ValidJson()
    {
        var result = Sources.GenerateHttpEnvironmentFile([], []);

        // Should not throw
        System.Text.Json.JsonDocument.Parse(result);
    }

    #endregion
}
