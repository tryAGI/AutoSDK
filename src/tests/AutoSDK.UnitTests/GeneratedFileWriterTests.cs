extern alias AutoSdkCli;

using GeneratedFileWriter = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedFileWriter;
using GeneratedOutputFile = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedOutputFile;

namespace AutoSDK.UnitTests;

[TestClass]
public class GeneratedFileWriterTests
{
    [TestMethod]
    public async Task WriteAsync_ReplacesFileAtomicallyForExternalReaders()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string oldText = "old complete content";
            const string newText = "new complete content";
            await File.WriteAllTextAsync(path, oldText);
            await using var existingReader = new FileStream(
                path,
                FileMode.Open,
                FileAccess.Read,
                FileShare.ReadWrite | FileShare.Delete);

            var result = await GeneratedFileWriter.WriteAsync(
                [new GeneratedOutputFile(path, newText)],
                staleCandidates: [],
                deleteStaleFiles: false);

            using var reader = new StreamReader(existingReader);
            (await reader.ReadToEndAsync()).Should().Be(oldText);
            (await File.ReadAllTextAsync(path)).Should().Be(newText);
            result.WrittenCount.Should().Be(1);
            Directory.GetFiles(tempDirectory, ".autosdk-*.tmp").Should().BeEmpty();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public async Task WriteAtomicallyAsync_WhenAlreadyCancelled_PreservesExistingFile()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string oldText = "old complete content";
            await File.WriteAllTextAsync(path, oldText);
            using var cancellation = new CancellationTokenSource();
            cancellation.Cancel();

            var action = async () => await GeneratedFileWriter.WriteAtomicallyAsync(
                path,
                "replacement",
                cancellation.Token);

            await action.Should().ThrowAsync<OperationCanceledException>();
            (await File.ReadAllTextAsync(path)).Should().Be(oldText);
            Directory.GetFiles(tempDirectory, ".autosdk-*.tmp").Should().BeEmpty();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    private static string CreateTempDirectory()
    {
        var path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(path);
        return path;
    }
}
