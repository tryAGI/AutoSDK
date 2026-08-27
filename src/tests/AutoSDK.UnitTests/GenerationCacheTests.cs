extern alias AutoSdkCli;

using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using AutoSDK.Models;
using GeneratedFileCacheEntry = AutoSdkCli::AutoSDK.CLI.Commands.GeneratedFileCacheEntry;
using GenerationCache = AutoSdkCli::AutoSDK.CLI.Commands.GenerationCache;

namespace AutoSDK.UnitTests;

[TestClass]
public class GenerationCacheTests
{
    [TestMethod]
    public async Task IsCacheEntryValidAsync_WhenMetadataMatches_DoesNotReopenFile()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string text = "generated content";
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

            (await GenerationCache.IsCacheEntryValidAsync(cachedFile)).Should().BeTrue();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public async Task IsCacheEntryValidAsync_WhenTimestampChanges_HashesSameLengthContent()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var path = Path.Combine(tempDirectory, "Client.g.cs");
            const string originalText = "generated content";
            const string changedText = "corrupted content";
            originalText.Length.Should().Be(changedText.Length);
            await File.WriteAllTextAsync(path, originalText);
            var fileInfo = new FileInfo(path);
            var cachedFile = new GeneratedFileCacheEntry(
                Path.GetFullPath(path),
                fileInfo.Length,
                fileInfo.LastWriteTimeUtc.Ticks,
                Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(originalText))));

            await File.WriteAllTextAsync(path, changedText);
            File.SetLastWriteTimeUtc(path, fileInfo.LastWriteTimeUtc.AddSeconds(1));

            (await GenerationCache.IsCacheEntryValidAsync(cachedFile)).Should().BeFalse();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public void CreateGeneratorFingerprint_UsesEffectiveSettingsAndSingleFileName()
    {
        var settings = Settings.Default with
        {
            Namespace = "Generated",
            ClassName = "GeneratedClient",
            IncludeModels = ["One", "Two"],
        };

        var first = GenerationCache.CreateGeneratorFingerprint(
            "openapi: 3.0.1",
            settings,
            singleFile: false,
            inputName: "first");
        var sameEffectiveConfiguration = GenerationCache.CreateGeneratorFingerprint(
            "openapi: 3.0.1",
            settings,
            singleFile: false,
            inputName: "second");
        var changedSettings = GenerationCache.CreateGeneratorFingerprint(
            "openapi: 3.0.1",
            settings with { Namespace = "Changed" },
            singleFile: false,
            inputName: "first");
        var changedSingleFileName = GenerationCache.CreateGeneratorFingerprint(
            "openapi: 3.0.1",
            settings,
            singleFile: true,
            inputName: "first");

        sameEffectiveConfiguration.Should().Be(first);
        changedSettings.Should().NotBe(first);
        changedSingleFileName.Should().NotBe(first);
    }

    [TestMethod]
    public async Task AcquireOutputLockAsync_WhenCacheRootIsUnavailable_ReturnsWithoutLock()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var cacheRoot = Path.Combine(tempDirectory, "cache-root");
            await File.WriteAllTextAsync(cacheRoot, "not a directory");

            await using var result = await GenerationCache.AcquireOutputLockAsync(
                Path.Combine(tempDirectory, "Generated"),
                cacheRoot,
                TimeSpan.FromSeconds(1));

            result.Acquired.Should().BeFalse();
            result.Reason.Should().Be("cache_unavailable");
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public async Task AcquireOutputLockAsync_WhenLockRemainsBusy_TimesOut()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var cacheRoot = Path.Combine(tempDirectory, "cache");
            var lockPath = $"{GenerationCache.GetCachePath(Path.GetFullPath(outputDirectory), cacheRoot)}.lock";
            Directory.CreateDirectory(cacheRoot);
            await using var heldLock = OpenExclusiveLock(lockPath);

            var started = Stopwatch.StartNew();
            await using var result = await GenerationCache.AcquireOutputLockAsync(
                outputDirectory,
                cacheRoot,
                TimeSpan.FromMilliseconds(75));

            result.Acquired.Should().BeFalse();
            result.Reason.Should().Be("timeout");
            started.Elapsed.Should().BeLessThan(TimeSpan.FromSeconds(2));
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    [TestMethod]
    public async Task AcquireOutputLockAsync_WhenCancelled_ThrowsPromptly()
    {
        var tempDirectory = CreateTempDirectory();
        try
        {
            var outputDirectory = Path.Combine(tempDirectory, "Generated");
            var cacheRoot = Path.Combine(tempDirectory, "cache");
            var lockPath = $"{GenerationCache.GetCachePath(Path.GetFullPath(outputDirectory), cacheRoot)}.lock";
            Directory.CreateDirectory(cacheRoot);
            await using var heldLock = OpenExclusiveLock(lockPath);
            using var cancellation = new CancellationTokenSource(TimeSpan.FromMilliseconds(75));

            var action = async () => await GenerationCache.AcquireOutputLockAsync(
                outputDirectory,
                cacheRoot,
                TimeSpan.FromSeconds(30),
                cancellation.Token);

            await action.Should().ThrowAsync<OperationCanceledException>();
        }
        finally
        {
            Directory.Delete(tempDirectory, recursive: true);
        }
    }

    private static FileStream OpenExclusiveLock(string path)
    {
        return new FileStream(
            path,
            FileMode.OpenOrCreate,
            FileAccess.ReadWrite,
            FileShare.None,
            bufferSize: 1,
            FileOptions.Asynchronous);
    }

    private static string CreateTempDirectory()
    {
        var path = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        Directory.CreateDirectory(path);
        return path;
    }
}
