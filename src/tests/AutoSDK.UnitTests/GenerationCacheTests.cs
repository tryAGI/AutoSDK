extern alias AutoSdkCli;

using System.Diagnostics;
using GenerationCache = AutoSdkCli::AutoSDK.CLI.Commands.GenerationCache;

namespace AutoSDK.UnitTests;

[TestClass]
public class GenerationCacheTests
{
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
