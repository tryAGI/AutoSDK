using System.Text.Json;
using AutoSDK.Docs;
using AutoSDK.Models;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class DocsSyncTests
{
    [TestMethod]
    public async Task SyncAsync_MetadataMode_UpdatesReadmeAndExamplePages()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "ElevenLabs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "IntegrationTests", "Examples"));

            await File.WriteAllTextAsync(
                Path.Combine(root, "README.md"),
                """
                # ElevenLabs

                <!-- EXAMPLES:START -->
                <!-- EXAMPLES:END -->
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "ElevenLabs", "ElevenLabs.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Examples", "SpeechToText.cs"),
                """
                /*
                title: Speech To Text
                order: 1

                Streams audio into text.
                */
                namespace ElevenLabs.IntegrationTests;

                public partial class Tests
                {
                    [TestMethod]
                    public async Task SpeechToText()
                    {
                        using var client = GetAuthenticatedClient();
                        //// Keep this comment.
                        var response = await client.TranscribeAsync();
                        response.Should().NotBeNull();
                    }
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("metadata");
            result.ExampleCount.Should().Be(1);

            var readme = await File.ReadAllTextAsync(Path.Combine(root, "README.md"));
            readme.Should().Contain("### Speech To Text");
            readme.Should().Contain("Streams audio into text.");

            var examplePage = await File.ReadAllTextAsync(Path.Combine(root, "docs", "examples", "speech-to-text.md"));
            examplePage.Should().Contain("This example assumes `using ElevenLabs;` is in scope");
            examplePage.Should().Contain("new ElevenLabsClient(apiKey)");
            examplePage.Should().Contain("// Keep this comment.");
            examplePage.Should().NotContain(".Should()");

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("examples/speech-to-text.md");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [TestMethod]
    public async Task SyncAsync_MetadataMode_AppliesCustomClientReplacements()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "HuggingFace"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "IntegrationTests", "Examples"));

            await File.WriteAllTextAsync(
                Path.Combine(root, "autosdk.docs.json"),
                """
                {
                    "clientReplacements": {
                        "GetAuthenticatedInferenceClient()": "HuggingFaceInferenceClient",
                        "GetAuthenticatedEmbeddingClient()": "HuggingFaceEmbeddingClient"
                    }
                }
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "README.md"),
                """
                # HuggingFace

                <!-- EXAMPLES:START -->
                <!-- EXAMPLES:END -->
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "HuggingFace", "HuggingFace.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Examples", "Inference.cs"),
                """
                /*
                title: Inference
                order: 1

                Run inference using a dedicated client.
                */
                namespace HuggingFace.IntegrationTests;

                public partial class Tests
                {
                    [TestMethod]
                    public async Task Inference()
                    {
                        var apiKey = GetApiKey();
                        using var client = GetAuthenticatedInferenceClient();
                        var response = await client.InferAsync();
                        response.Should().NotBeNull();
                    }
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("metadata");
            result.ExampleCount.Should().Be(1);

            var examplePage = await File.ReadAllTextAsync(Path.Combine(root, "docs", "examples", "inference.md"));
            examplePage.Should().Contain("new HuggingFaceInferenceClient(apiKey)");
            examplePage.Should().NotContain("GetAuthenticatedInferenceClient");
            examplePage.Should().NotContain("GetApiKey()");
            examplePage.Should().NotContain(".Should()");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [TestMethod]
    public async Task SyncAsync_NoFrontMatter_DerivesTitleFromFilename()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "Tavily"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "IntegrationTests", "Examples"));

            await File.WriteAllTextAsync(Path.Combine(root, "README.md"), "# Tavily\n");
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "Tavily", "Tavily.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Examples", "Search.cs"),
                """
                namespace Tavily.IntegrationTests;

                public partial class Tests
                {
                    [TestMethod]
                    public async Task Search()
                    {
                        using var client = GetAuthenticatedClient();
                        var response = await client.SearchAsync("hello");
                        response.Should().NotBeNull();
                    }
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("metadata");
            result.ExampleCount.Should().Be(1);

            var examplePage = await File.ReadAllTextAsync(Path.Combine(root, "docs", "examples", "search.md"));
            examplePage.Should().Contain("# Search");
            examplePage.Should().Contain("new TavilyClient(apiKey)");
            examplePage.Should().NotContain(".Should()");

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("examples/search.md");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [TestMethod]
    public async Task SyncAsync_SkipsFilesWithNoTestMethod()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "TestSdk"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "IntegrationTests", "Examples"));

            await File.WriteAllTextAsync(Path.Combine(root, "README.md"), "# TestSdk\n");
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "TestSdk", "TestSdk.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            // File with no test method
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Examples", "CommentedOut.cs"),
                """
                // namespace TestSdk.IntegrationTests;
                //
                // public partial class Tests
                // {
                //     [TestMethod]
                //     public async Task Commented() { }
                // }
                """);
            // File with a valid test method
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Examples", "Valid.cs"),
                """
                namespace TestSdk.IntegrationTests;

                public partial class Tests
                {
                    [TestMethod]
                    public async Task Valid()
                    {
                        using var client = GetAuthenticatedClient();
                    }
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.ExampleCount.Should().Be(1);

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("examples/valid.md");
            mkDocs.Should().NotContain("commented");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    [TestMethod]
    public async Task SyncAsync_GeneratedExamples_MergesLanguageAndSetup()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "GeneratedSdk"));

            await File.WriteAllTextAsync(
                Path.Combine(root, "README.md"),
                """
                # GeneratedSdk

                <!-- EXAMPLES:START -->
                <!-- EXAMPLES:END -->
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "GeneratedSdk", "GeneratedSdk.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "autosdk.generated-examples.json"),
                JsonSerializer.Serialize(
                    new GeneratedSdkSnippetManifest(
                    [
                        new GeneratedSdkSnippetDocument(
                            Order: 1,
                            Title: "Upload File",
                            Slug: "upload-file",
                            Description: "Uses the generated HTTP fallback snippet.",
                            Language: "http",
                            Code: "POST {{host}}/uploads",
                            Format: "http",
                            OperationId: "uploadFile",
                            Setup: "This example uses the generated HTTP request snippet.")
                    ]),
                    new JsonSerializerOptions
                    {
                        WriteIndented = true,
                    }));

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("metadata");
            result.ExampleCount.Should().Be(1);

            var readme = await File.ReadAllTextAsync(Path.Combine(root, "README.md"));
            readme.Should().Contain("### Upload File");
            readme.Should().Contain("```http");

            var examplePage = await File.ReadAllTextAsync(Path.Combine(root, "docs", "examples", "upload-file.md"));
            examplePage.Should().Contain("This example uses the generated HTTP request snippet.");
            examplePage.Should().Contain("```http");
            examplePage.Should().Contain("POST {{host}}/uploads");

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("examples/upload-file.md");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

    private static string CreateTempDirectory()
    {
        var path = Path.Combine(Path.GetTempPath(), "autosdk-docs-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(path);
        return path;
    }
}
