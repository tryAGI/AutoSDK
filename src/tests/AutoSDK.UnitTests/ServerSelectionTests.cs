using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public class ServerSelectionTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "ServerClient",
        GenerateModels = true,
    };

    [TestMethod]
    public void Prepare_PathAndOperationServers_UsesCorrectPrecedence()
    {
        var data = PrepareData("""
openapi: 3.0.3
info:
  title: Server Selection
  version: 1.0.0
servers:
  - url: https://api.example.com/v1
    description: Public API
paths:
  /users:
    get:
      operationId: listUsers
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
  /admin/audits:
    servers:
      - url: https://admin.example.com/v2
        description: Admin API
    get:
      operationId: listAdminAudits
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
  /admin/stats:
    servers:
      - url: https://admin.example.com/v2
        description: Admin API
    get:
      operationId: getAdminStats
      servers:
        - url: https://stats.example.com/v3
          description: Stats API
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
""");

        data.Clients.Should().ContainSingle();
        data.Clients[0].BaseUrl.Should().Be("https://api.example.com/v1");
        data.Clients[0].Servers.Select(x => x.Url).Should().BeEquivalentTo(
            "https://api.example.com/v1",
            "https://admin.example.com/v2",
            "https://stats.example.com/v3");
        data.Clients[0].UsesServerSelectionSupport.Should().BeTrue();

        data.Methods.Single(x => x.NotAsyncMethodName == "ListUsers").BaseUrl.Should().Be("https://api.example.com/v1");
        data.Methods.Single(x => x.NotAsyncMethodName == "ListAdminAudits").BaseUrl.Should().Be("https://admin.example.com/v2");
        data.Methods.Single(x => x.NotAsyncMethodName == "GetAdminStats").BaseUrl.Should().Be("https://stats.example.com/v3");
        data.Methods.Single(x => x.NotAsyncMethodName == "ListUsers").ClientUsesServerSelectionSupport.Should().BeTrue();
        data.Methods.Single(x => x.NotAsyncMethodName == "ListAdminAudits").HasServerOverride.Should().BeTrue();
        data.Methods.Single(x => x.NotAsyncMethodName == "GetAdminStats").HasServerOverride.Should().BeTrue();
    }

    [TestMethod]
    public void GenerateClient_MultiServerSpec_EmitsSelectionApi()
    {
        var data = PrepareData("""
openapi: 3.0.3
info:
  title: Multi Server
  version: 1.0.0
servers:
  - url: https://api.example.com/v1
    description: Public API
  - url: https://staging.example.com/v1
    description: Staging API
paths:
  /users:
    get:
      operationId: listUsers
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
""");

        var clientCode = Sources.GenerateClient(data.Clients[0]);
        var fileNames = CSharpPipeline.GenerateFiles(data).Select(x => x.Name).ToArray();

        clientCode.Should().Contain("AvailableServers => s_availableServers");
        clientCode.Should().Contain("TrySelectServer(string serverId)");
        clientCode.Should().Contain("SelectedServer");
        clientCode.Should().Contain("https://staging.example.com/v1");
        clientCode.Should().Contain("if (baseUri is not null)");
        clientCode.Should().NotContain("HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);");
        clientCode.Should().Contain("return ResolveSelectedServer()?.Uri ?? (s_availableServers.Length > 0 ? s_availableServers[0].Uri : HttpClient.BaseAddress);");
        fileNames.Should().Contain("G.ServerSelection.g.cs");
    }

    [TestMethod]
    public void GenerateEndPoint_GroupedSingleScopedServer_UsesScopedServerWithSharedConfiguration()
    {
        var data = PrepareData("""
openapi: 3.0.3
info:
  title: Grouped Server Selection
  version: 1.0.0
servers:
  - url: https://api.example.com/v1
    description: Public API
paths:
  /transcriptions:
    post:
      operationId: createTranscription
      tags:
        - transcriptions
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
  /tts:
    servers:
      - url: https://tts.example.com/
        description: TTS API
    post:
      operationId: generateTts
      tags:
        - tts
      responses:
        '200':
          description: OK
          content:
            application/octet-stream:
              schema:
                type: string
                format: binary
""");

        var ttsClient = data.Clients.Single(x => x.ClassName == "TtsClient");
        var ttsMethod = data.Methods.Single(x => x.NotAsyncMethodName == "GenerateTts");
        var clientCode = Sources.GenerateClient(ttsClient);
        var methodCode = Sources.GenerateEndPoint(ttsMethod);

        ttsClient.Servers.Select(x => x.Url).Should().BeEquivalentTo("https://tts.example.com/");
        ttsClient.UsesServerSelectionSupport.Should().BeTrue();
        ttsClient.NeedsScopedServerResolver.Should().BeTrue();
        ttsMethod.HasServerOverride.Should().BeTrue();
        ttsMethod.UsesServerSelectionSupport.Should().BeTrue();
        ttsMethod.ClientUsesServerSelectionSupport.Should().BeFalse();
        clientCode.Should().Contain("private global::System.Uri? ResolveBaseUri(");
        clientCode.Should().NotContain("AvailableServers => s_availableServers");
        methodCode.Should().Contain("s_GenerateTtsServers");
        methodCode.Should().Contain("baseUri: ResolveBaseUri(");
        methodCode.Should().Contain("defaultBaseUrl: \"https://tts.example.com/\"");
    }

    [TestMethod]
    public void GenerateEndPoint_SingleScopedServer_UsesDirectFallbackWithoutSelectionSupport()
    {
        var data = PrepareData("""
openapi: 3.0.3
info:
  title: Scoped Server
  version: 1.0.0
paths:
  /admin:
    servers:
      - url: https://admin.example.com/v2
        description: Admin API
    get:
      operationId: getAdmin
      responses:
        '200':
          description: OK
          content:
            application/json:
              schema:
                type: object
""");

        data.Clients.Should().ContainSingle();
        data.Clients[0].UsesServerSelectionSupport.Should().BeFalse();

        var endPoint = data.Methods.Single();
        var methodCode = Sources.GenerateEndPoint(endPoint);
        var fileNames = CSharpPipeline.GenerateFiles(data).Select(x => x.Name).ToArray();

        endPoint.HasServerOverride.Should().BeTrue();
        endPoint.ClientUsesServerSelectionSupport.Should().BeFalse();
        methodCode.Should().Contain("HttpClient.BaseAddress ?? new global::System.Uri(\"https://admin.example.com/v2\"");
        methodCode.Should().NotContain("ResolveBaseUri(");
        fileNames.Should().NotContain("G.ServerSelection.g.cs");
    }

    private static AutoSDK.Models.Data PrepareData(string yaml)
    {
        var settings = DefaultSettings;
        return AutoSDK.Generation.Data.Prepare(((yaml, settings), GlobalSettings: settings));
    }
}
