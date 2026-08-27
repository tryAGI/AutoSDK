extern alias AutoSdkCli;

using System.Security.Cryptography;
using System.Text;
using GeneratedFileCacheEntry = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedFileCacheEntry;
using GeneratedFileWriter = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedFileWriter;
using GeneratedOutputFile = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedOutputFile;

namespace AutoSDK.UnitTests;

[TestClass]
public class GeneratedFileWriterTests
{
    [TestMethod]
    public async Task WriteAsync_WhenManifestMetadataAndHashMatch_DoesNotReopenFile()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string text = "complete generated content";
            await File.WriteAllTextAsync(path, text);
            var fileInfo = new FileInfo(path);
            var cachedFile = new GeneratedFileCacheEntry(
                Path.GetFullPath(path),
                fileInfo.Length,
                fileInfo.LastWriteTimeUtc.Ticks,
                Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(text))));
            await using var exclusiveReader = new FileStream(
                path,
                FileMode.Open,
                FileAccess.Read,
                FileShare.None);

            var result = await GeneratedFileWriter.WriteAsync(
                [new GeneratedOutputFile(path, text)],
                staleCandidates: [],
                deleteStaleFiles: false,
                cachedFiles: [cachedFile]);

            result.WrittenCount.Should().Be(0);
            result.UnchangedCount.Should().Be(1);
            result.CacheFiles.Should().ContainSingle().Which.Should().Be(cachedFile);
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

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
            var writtenFileInfo = new FileInfo(path);
            result.CacheFiles.Should().ContainSingle().Which.Should().Be(new GeneratedFileCacheEntry(
                Path.GetFullPath(path),
                writtenFileInfo.Length,
                writtenFileInfo.LastWriteTimeUtc.Ticks,
                Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(newText)))));
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
