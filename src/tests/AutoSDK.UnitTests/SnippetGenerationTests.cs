using System.Text.Json;
using AutoSDK.Extensions;
using AutoSDK.Generation;
using AutoSDK.Helpers;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class SnippetGenerationTests
{
    private static Settings DefaultSettings => Settings.Default with
    {
        Namespace = "G",
        ClassName = "ExampleClient",
        GenerateMethods = true,
        GenerateSdk = true,
    };

    [TestMethod]
    public void GenerateSnippetManifest_WithJsonExamples_EmitsSdkSnippet()
    {
        var yaml = """
                   openapi: 3.0.1
                   info:
                     title: Test
                     version: 1.0.0
                   paths:
                     /items/{itemId}:
                       post:
                         operationId: createItem
                         summary: Create item
                         parameters:
                           - name: itemId
                             in: path
                             required: true
                             schema:
                               type: string
                             example: item_123
                           - name: includeDetails
                             in: query
                             schema:
                               type: boolean
                             example: true
                         requestBody:
                           required: true
                           content:
                             application/json:
                               example:
                                 name: widget
                                 count: 3
                               schema:
                                 type: object
                                 required:
                                   - name
                                 properties:
                                   name:
                                     type: string
                                   count:
                                     type: integer
                         responses:
                           '201':
                             description: Created
                             content:
                               application/json:
                                 example:
                                   id: item_123
                                   status: created
                                 schema:
                                   type: object
                                   properties:
                                     id:
                                       type: string
                                     status:
                                       type: string
                   """;

        var document = yaml.GetOpenApiDocument(DefaultSettings);
        var schemas = document.GetSchemas(DefaultSettings);
        var operations = document.GetOperations(DefaultSettings, globalSettings: DefaultSettings, schemas);
        var data = CSharpPipeline.PrepareAndEnrich(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        var manifestJson = Sources.GenerateSnippetManifest(operations, data.Methods.ToArray());
        var manifest = JsonSerializer.Deserialize<GeneratedSdkSnippetManifest>(manifestJson);

        manifest.Should().NotBeNull();
        manifest!.Examples.Should().ContainSingle();

        var snippet = manifest.Examples[0];
        snippet.Language.Should().Be("csharp");
        snippet.Format.Should().Be("sdk");
        snippet.Code.Should().Contain("using var client = new ExampleClient();");
        snippet.Code.Should().Contain("var request = global::System.Text.Json.JsonSerializer.Deserialize<");
        snippet.Code.Should().Contain("itemId: \"item_123\"");
        snippet.Code.Should().Contain("includeDetails: true");
        snippet.Code.Should().Contain("var response = await client.CreateItemAsync(");
        snippet.Code.Should().Contain("// Example response:");
        snippet.Setup.Should().Contain("using G;");
    }

    [TestMethod]
    public void GenerateSnippetManifest_WithUnsupportedSdkShape_FallsBackToHttp()
    {
        var yaml = """
                   openapi: 3.0.1
                   info:
                     title: Test
                     version: 1.0.0
                   paths:
                     /uploads:
                       post:
                         operationId: uploadFile
                         summary: Upload file
                         requestBody:
                           required: true
                           content:
                             multipart/form-data:
                               example:
                                 file: example.txt
                               schema:
                                 type: object
                                 properties:
                                   file:
                                     type: string
                                     format: binary
                         responses:
                           '202':
                             description: Accepted
                   """;

        var document = yaml.GetOpenApiDocument(DefaultSettings);
        var schemas = document.GetSchemas(DefaultSettings);
        var operations = document.GetOperations(DefaultSettings, globalSettings: DefaultSettings, schemas);
        var data = CSharpPipeline.PrepareAndEnrich(((yaml, DefaultSettings), GlobalSettings: DefaultSettings));

        var manifestJson = Sources.GenerateSnippetManifest(operations, data.Methods.ToArray());
        var manifest = JsonSerializer.Deserialize<GeneratedSdkSnippetManifest>(manifestJson);

        manifest.Should().NotBeNull();
        manifest!.Examples.Should().ContainSingle();

        var snippet = manifest.Examples[0];
        snippet.Language.Should().Be("http");
        snippet.Format.Should().Be("http");
        snippet.Code.Should().Contain("POST {{host}}/uploads");
        snippet.Code.Should().Contain("Content-Type: multipart/form-data");
    }

    [TestMethod]
    public void GenerateSnippetManifest_WhenExcludedDeprecatedOperationHasExamples_FallsBackToHttp()
    {
        var yaml = """
                   openapi: 3.0.1
                   info:
                     title: Test
                     version: 1.0.0
                   paths:
                     /legacy:
                       post:
                         operationId: createLegacyItem
                         deprecated: true
                         summary: Create legacy item
                         requestBody:
                           required: true
                           content:
                             application/json:
                               example:
                                 name: legacy
                               schema:
                                 type: object
                                 properties:
                                   name:
                                     type: string
                         responses:
                           '201':
                             description: Created
                             content:
                               application/json:
                                 example:
                                   id: legacy_123
                                 schema:
                                   type: object
                                   properties:
                                     id:
                                       type: string
                   """;

        var settings = DefaultSettings with
        {
            ExcludeDeprecatedOperations = true,
        };

        var document = yaml.GetOpenApiDocument(settings);
        var schemas = document.GetSchemas(settings);
        var operations = document.GetOperations(settings, globalSettings: settings, schemas);
        var data = CSharpPipeline.PrepareAndEnrich(((yaml, settings), GlobalSettings: settings));

        data.Methods.Should().BeEmpty();

        var manifestJson = Sources.GenerateSnippetManifest(operations, data.Methods.ToArray());
        var manifest = JsonSerializer.Deserialize<GeneratedSdkSnippetManifest>(manifestJson);

        manifest.Should().NotBeNull();
        manifest!.Examples.Should().ContainSingle();

        var snippet = manifest.Examples[0];
        snippet.OperationId.Should().Be("createLegacyItem");
        snippet.Language.Should().Be("http");
        snippet.Format.Should().Be("http");
        snippet.Code.Should().Contain("POST {{host}}/legacy");
    }
}
