using AutoSDK.Docs;

namespace AutoSDK.UnitTests;

[TestClass]
public sealed class DocsSyncTests
{
    [TestMethod]
    public async Task SyncAsync_LegacyMode_ExtractsDisabledTestExamples()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "Firecrawl"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "IntegrationTests"));

            await File.WriteAllTextAsync(Path.Combine(root, "README.md"), "# Firecrawl\n");
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "Firecrawl", "Firecrawl.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "IntegrationTests", "Tests.Crawl.cs"),
                """
                namespace Firecrawl.IntegrationTests;

                public partial class Tests
                {
                    // [TestMethod]
                    // public async Task Crawl()
                    // {
                    //     using var client = GetAuthenticatedClient();
                    //     response.Should().NotBeNull();
                    //     Console.WriteLine("ok");
                    // }
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("legacy");
            result.ExampleCount.Should().Be(1);

            var sample = await File.ReadAllTextAsync(Path.Combine(root, "docs", "samples", "Crawl.md"));
            sample.Should().Contain("new FirecrawlClient(apiKey)");
            sample.Should().Contain("Console.WriteLine(\"ok\");");
            sample.Should().NotContain(".Should()");

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("samples/Crawl.md");
        }
        finally
        {
            Directory.Delete(root, recursive: true);
        }
    }

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
    public async Task SyncAsync_MarkerMode_GroupsExamplesInMkDocs()
    {
        var root = CreateTempDirectory();

        try
        {
            Directory.CreateDirectory(Path.Combine(root, "docs"));
            Directory.CreateDirectory(Path.Combine(root, "src", "libs", "OpenAI"));
            Directory.CreateDirectory(Path.Combine(root, "src", "tests", "OpenAI.IntegrationTests"));

            await File.WriteAllTextAsync(Path.Combine(root, "README.md"), "# OpenAI\n");
            await File.WriteAllTextAsync(
                Path.Combine(root, "mkdocs.yml"),
                """
                nav:
                - Overview: index.md
                # EXAMPLES:START
                # EXAMPLES:END
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "libs", "OpenAI", "OpenAI.csproj"),
                "<Project Sdk=\"Microsoft.NET.Sdk\" />");
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "OpenAI.IntegrationTests", "Examples.Chat.Simple.cs"),
                """
                namespace OpenAI.IntegrationTests;

                public partial class Examples
                {
                    // # START EXAMPLE #
                    using var client = GetAuthenticatedClient();
                    response.Should().NotBeNull();
                    Console.WriteLine("simple");
                }
                """);
            await File.WriteAllTextAsync(
                Path.Combine(root, "src", "tests", "OpenAI.IntegrationTests", "Examples.Chat.Streaming.cs"),
                """
                namespace OpenAI.IntegrationTests;

                public partial class Examples
                {
                    // # START EXAMPLE #
                    using var client = GetAuthenticatedClient();
                    Console.WriteLine("streaming");
                }
                """);

            var result = await DocsSynchronizer.SyncAsync(root);

            result.Mode.Should().Be("marker");
            result.ExampleCount.Should().Be(2);

            var mkDocs = await File.ReadAllTextAsync(Path.Combine(root, "mkdocs.yml"));
            mkDocs.Should().Contain("  - Chat:");
            mkDocs.Should().Contain("    - Simple: samples/Chat.Simple.md");
            mkDocs.Should().Contain("    - Streaming: samples/Chat.Streaming.md");
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
