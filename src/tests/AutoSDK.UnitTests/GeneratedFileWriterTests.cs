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
            result.CreatedCount.Should().Be(0);
            result.ReplacedCount.Should().Be(0);
            result.UnchangedCount.Should().Be(1);
            result.CacheFiles.Should().ContainSingle().Which.Should().Be(cachedFile);
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public async Task WriteAsync_WhenTargetDoesNotExist_CreatesFileDirectly()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string text = "new generated content";

            var result = await GeneratedFileWriter.WriteAsync(
                [new GeneratedOutputFile(path, text)],
                staleCandidates: [],
                deleteStaleFiles: false);

            (await File.ReadAllTextAsync(path)).Should().Be(text);
            result.WrittenCount.Should().Be(1);
            result.CreatedCount.Should().Be(1);
            result.ReplacedCount.Should().Be(0);
            Directory.GetFiles(tempDirectory, ".autosdk-*.tmp").Should().BeEmpty();
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
            result.CreatedCount.Should().Be(0);
            result.ReplacedCount.Should().Be(1);
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
    public async Task WriteAsync_WhenSameLengthUtf8ContentDiffers_ReplacesFile()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "nested", "Client.g.cs");
            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            const string oldText = "old café";
            const string newText = "new café";
            Encoding.UTF8.GetByteCount(oldText).Should().Be(Encoding.UTF8.GetByteCount(newText));
            await File.WriteAllTextAsync(path, oldText);

            var result = await GeneratedFileWriter.WriteAsync(
                [new GeneratedOutputFile(path, newText)],
                staleCandidates: [],
                deleteStaleFiles: false);

            result.WrittenCount.Should().Be(1);
            result.CreatedCount.Should().Be(0);
            result.ReplacedCount.Should().Be(1);
            (await File.ReadAllTextAsync(path)).Should().Be(newText);
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public void NormalizeTrailingWhitespace_PreservesLineEndingsAndReportsChangedLines()
    {
        const string text = "first  \r\nsecond\t\nthird  ";

        var result = GeneratedFileWriter.NormalizeTrailingWhitespace(text, out var normalizedLines);

        result.Should().Be("first\r\nsecond\nthird");
        normalizedLines.Should().Be(3);
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
