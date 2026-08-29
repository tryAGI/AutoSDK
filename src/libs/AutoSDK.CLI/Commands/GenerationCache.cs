using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using AutoSDK.Generation;
using AutoSDK.Models;

namespace AutoSDK.CLI.Commands;

internal sealed record GenerationCacheManifest(
    int FormatVersion,
    string GeneratorFingerprint,
    string OutputDirectory,
    GenerationCacheFile[] Files);

internal sealed record GenerationCacheFile(
    string RelativePath,
    long Length,
    long LastWriteTimeUtcTicks,
    string Sha256);

internal sealed record GenerationFingerprint(
    Settings Settings,
    bool SingleFile,
    string SingleFileName);

internal sealed record GeneratedFileCacheEntry(
    string Path,
    long Length,
    long LastWriteTimeUtcTicks,
    string Sha256);

internal readonly record struct GenerationCacheValidation(
    bool Hit,
    string Reason,
    GeneratedFileWriteResult Files,
    GeneratedFileCacheEntry[] KnownFiles);

internal sealed class GenerationCacheLock : IAsyncDisposable
{
    private readonly FileStream? handle;

    public GenerationCacheLock(string lockPath)
    {
        handle = new FileStream(
            lockPath,
            new FileStreamOptions
            {
                Access = FileAccess.ReadWrite,
                Mode = FileMode.OpenOrCreate,
                Options = FileOptions.Asynchronous,
                Share = FileShare.None,
            });
        Acquired = true;
        Reason = "acquired";
    }

    private GenerationCacheLock(string reason, bool acquired)
    {
        Acquired = acquired;
        Reason = reason;
    }

    public bool Acquired { get; }

    public string Reason { get; }

    public static GenerationCacheLock NotAcquired(string reason)
    {
        return new GenerationCacheLock(reason, acquired: false);
    }

    public ValueTask DisposeAsync()
    {
        return handle?.DisposeAsync() ?? ValueTask.CompletedTask;
    }
}

internal static class GenerationCache
{
    private const int FormatVersion = 2;
    private const int MaxParallelism = 8;
    private static readonly TimeSpan DefaultLockTimeout = TimeSpan.FromSeconds(30);
    private static readonly TimeSpan LockRetryDelay = TimeSpan.FromMilliseconds(25);

    public static Task<GenerationCacheLock> AcquireOutputLockAsync(
        string outputDirectory,
        CancellationToken cancellationToken = default)
    {
        return AcquireOutputLockAsync(
            outputDirectory,
            GetDefaultCacheRoot(),
            DefaultLockTimeout,
            cancellationToken);
    }

    internal static async Task<GenerationCacheLock> AcquireOutputLockAsync(
        string outputDirectory,
        string cacheRoot,
        TimeSpan timeout,
        CancellationToken cancellationToken = default)
    {
        outputDirectory = Path.GetFullPath(outputDirectory);
        ArgumentOutOfRangeException.ThrowIfLessThan(timeout, TimeSpan.Zero);

        cancellationToken.ThrowIfCancellationRequested();
        var lockPath = $"{GetCachePath(outputDirectory, cacheRoot)}.lock";
        try
        {
            Directory.CreateDirectory(Path.GetDirectoryName(lockPath)!);
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException)
        {
            return GenerationCacheLock.NotAcquired("cache_unavailable");
        }

        var waitTime = Stopwatch.StartNew();
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            try
            {
                return new GenerationCacheLock(lockPath);
            }
            catch (IOException)
            {
                var remaining = timeout - waitTime.Elapsed;
                if (remaining <= TimeSpan.Zero)
                {
                    return GenerationCacheLock.NotAcquired("timeout");
                }

                await Task.Delay(
                    remaining < LockRetryDelay ? remaining : LockRetryDelay,
                    cancellationToken).ConfigureAwait(false);
            }
            catch (UnauthorizedAccessException)
            {
                return GenerationCacheLock.NotAcquired("cache_unavailable");
            }
        }
    }

    public static string CreateGeneratorFingerprint(
        string inputText,
        Settings settings,
        bool singleFile,
        string inputName)
    {
        inputText = inputText ?? throw new ArgumentNullException(nameof(inputText));
        inputName = inputName ?? throw new ArgumentNullException(nameof(inputName));

        using var hash = IncrementalHash.CreateHash(HashAlgorithmName.SHA256);
        Append(hash, FormatVersion.ToString(System.Globalization.CultureInfo.InvariantCulture));
        Append(hash, typeof(GenerationCache).Assembly.ManifestModule.ModuleVersionId.ToString("N"));
        Append(hash, typeof(CSharpPipeline).Assembly.ManifestModule.ModuleVersionId.ToString("N"));
        Append(hash, typeof(Settings).Assembly.ManifestModule.ModuleVersionId.ToString("N"));
        Append(hash, inputText);
        var fingerprint = new GenerationFingerprint(
            settings,
            singleFile,
            singleFile ? inputName : string.Empty);
        Append(
            hash,
            JsonSerializer.SerializeToUtf8Bytes(
                fingerprint,
                CliJsonSerializerContext.Default.GenerationFingerprint));

        return Convert.ToHexString(hash.GetHashAndReset());
    }

    public static async Task<GenerationCacheValidation> TryValidateAsync(
        string outputDirectory,
        string generatorFingerprint,
        IEnumerable<string> staleCandidates,
        bool rejectUnexpectedGeneratedFiles,
        CancellationToken cancellationToken = default)
    {
        outputDirectory = Path.GetFullPath(outputDirectory);
        var cachePath = GetCachePath(outputDirectory);
        if (!File.Exists(cachePath))
        {
            return Miss("manifest_not_found");
        }

        GenerationCacheManifest? manifest;
        try
        {
            using var stream = File.OpenRead(cachePath);
            manifest = await JsonSerializer.DeserializeAsync(
                stream,
                CliJsonSerializerContext.Default.GenerationCacheManifest,
                cancellationToken).ConfigureAwait(false);
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException or JsonException)
        {
            return Miss("manifest_unreadable");
        }

        if (manifest is null ||
            manifest.FormatVersion != FormatVersion ||
            !PathEquals(manifest.OutputDirectory, outputDirectory))
        {
            return Miss("fingerprint_changed");
        }

        var expectedPaths = new HashSet<string>(PathComparer);
        var knownFiles = new GeneratedFileCacheEntry[manifest.Files.Length];
        long generatedBytes = 0;
        for (var index = 0; index < manifest.Files.Length; index++)
        {
            var file = manifest.Files[index];
            if (!TryResolveOutputPath(outputDirectory, file.RelativePath, out var fullPath) ||
                !expectedPaths.Add(fullPath))
            {
                return Miss("manifest_invalid");
            }

            knownFiles[index] = new GeneratedFileCacheEntry(
                fullPath,
                file.Length,
                file.LastWriteTimeUtcTicks,
                file.Sha256);
            generatedBytes += file.Length;
        }

        if (!string.Equals(manifest.GeneratorFingerprint, generatorFingerprint, StringComparison.Ordinal))
        {
            return Miss("fingerprint_changed", knownFiles);
        }

        if (rejectUnexpectedGeneratedFiles)
        {
            foreach (var staleCandidate in staleCandidates)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (File.Exists(staleCandidate) && !expectedPaths.Contains(Path.GetFullPath(staleCandidate)))
                {
                    return Miss("stale_output_found", knownFiles);
                }
            }
        }

        var valid = 1;
        await Parallel.ForEachAsync(
            knownFiles,
            new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxParallelism),
            },
            async (file, itemCancellationToken) =>
            {
                if (Volatile.Read(ref valid) == 0 ||
                    !await IsCacheEntryValidAsync(file, itemCancellationToken).ConfigureAwait(false))
                {
                    Interlocked.Exchange(ref valid, 0);
                }
            }).ConfigureAwait(false);

        return valid == 0
            ? Miss("output_changed", knownFiles)
            : new GenerationCacheValidation(
                Hit: true,
                Reason: "hit",
                Files: new GeneratedFileWriteResult(
                    GeneratedCount: manifest.Files.Length,
                    WrittenCount: 0,
                    CreatedCount: 0,
                    ReplacedCount: 0,
                    UnchangedCount: manifest.Files.Length,
                    DeletedCount: 0,
                    NormalizedLineCount: 0,
                    GeneratedBytes: generatedBytes,
                    WrittenBytes: 0,
                    CacheFiles: knownFiles,
                    Diagnostics: default),
            KnownFiles: knownFiles);
    }

    internal static async Task<bool> IsCacheEntryValidAsync(
        GeneratedFileCacheEntry file,
        CancellationToken cancellationToken = default)
    {
        var fileInfo = new FileInfo(file.Path);
        if (!fileInfo.Exists || fileInfo.Length != file.Length)
        {
            return false;
        }

        if (fileInfo.LastWriteTimeUtc.Ticks == file.LastWriteTimeUtcTicks)
        {
            return true;
        }

        return string.Equals(
            await ComputeFileHashAsync(file.Path, cancellationToken).ConfigureAwait(false),
            file.Sha256,
            StringComparison.Ordinal);
    }

    public static async Task SaveAsync(
        string outputDirectory,
        string generatorFingerprint,
        IEnumerable<GeneratedFileCacheEntry> generatedFiles,
        CancellationToken cancellationToken = default)
    {
        try
        {
            await SaveCoreAsync(
                outputDirectory,
                generatorFingerprint,
                generatedFiles,
                cancellationToken).ConfigureAwait(false);
        }
        catch (Exception exception) when (exception is IOException or UnauthorizedAccessException)
        {
            // Caching is an optimization and must not turn successful generation into a failure.
        }
    }

    private static async Task SaveCoreAsync(
        string outputDirectory,
        string generatorFingerprint,
        IEnumerable<GeneratedFileCacheEntry> generatedFiles,
        CancellationToken cancellationToken)
    {
        outputDirectory = Path.GetFullPath(outputDirectory);
        var generatedFileEntries = generatedFiles
            .GroupBy(static file => Path.GetFullPath(file.Path), PathComparer)
            .Select(static group => group.First() with { Path = group.Key })
            .OrderBy(static file => file.Path, PathComparer)
            .ToArray();
        var files = new GenerationCacheFile[generatedFileEntries.Length];

        for (var index = 0; index < generatedFileEntries.Length; index++)
        {
            cancellationToken.ThrowIfCancellationRequested();
            var generatedFile = generatedFileEntries[index];
            var relativePath = Path.GetRelativePath(outputDirectory, generatedFile.Path);
            if (!TryResolveOutputPath(outputDirectory, relativePath, out var resolvedPath) ||
                !PathEquals(generatedFile.Path, resolvedPath))
            {
                throw new InvalidOperationException(
                    $"Generated output '{generatedFile.Path}' is outside '{outputDirectory}'.");
            }

            files[index] = new GenerationCacheFile(
                RelativePath: relativePath,
                Length: generatedFile.Length,
                LastWriteTimeUtcTicks: generatedFile.LastWriteTimeUtcTicks,
                Sha256: generatedFile.Sha256);
        }

        var manifest = new GenerationCacheManifest(
            FormatVersion,
            generatorFingerprint,
            outputDirectory,
            files);
        var cachePath = GetCachePath(outputDirectory);
        Directory.CreateDirectory(Path.GetDirectoryName(cachePath)!);
        var temporaryPath = $"{cachePath}.{Guid.NewGuid():N}.tmp";
        try
        {
            using (var stream = File.Create(temporaryPath))
            {
                await JsonSerializer.SerializeAsync(
                    stream,
                    manifest,
                    CliJsonSerializerContext.Default.GenerationCacheManifest,
                    cancellationToken).ConfigureAwait(false);
            }

            File.Move(temporaryPath, cachePath, overwrite: true);
        }
        finally
        {
            if (File.Exists(temporaryPath))
            {
                File.Delete(temporaryPath);
            }
        }
    }

    private static GenerationCacheValidation Miss(
        string reason,
        GeneratedFileCacheEntry[]? knownFiles = null)
    {
        return new GenerationCacheValidation(false, reason, default, knownFiles ?? []);
    }

    private static string GetCachePath(string outputDirectory)
    {
        return GetCachePath(outputDirectory, GetDefaultCacheRoot());
    }

    internal static string GetCachePath(string outputDirectory, string cacheRoot)
    {
        cacheRoot = Path.GetFullPath(cacheRoot);
        var key = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(outputDirectory)));
        return Path.Combine(cacheRoot, $"{key}.json");
    }

    private static string GetDefaultCacheRoot()
    {
        var localApplicationData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        if (string.IsNullOrWhiteSpace(localApplicationData))
        {
            localApplicationData = Path.GetTempPath();
        }

        return Path.Combine(
            localApplicationData,
            "AutoSDK",
            "generation-cache");
    }

    private static bool TryResolveOutputPath(
        string outputDirectory,
        string relativePath,
        out string fullPath)
    {
        fullPath = Path.GetFullPath(Path.Combine(outputDirectory, relativePath));
        var relative = Path.GetRelativePath(outputDirectory, fullPath);
        return relative != ".." &&
               !relative.StartsWith($"..{Path.DirectorySeparatorChar}", StringComparison.Ordinal) &&
               !Path.IsPathRooted(relative);
    }

    private static async Task<string> ComputeFileHashAsync(
        string path,
        CancellationToken cancellationToken)
    {
        using var stream = new FileStream(
            path,
            new FileStreamOptions
            {
                Access = FileAccess.Read,
                Mode = FileMode.Open,
                Options = FileOptions.Asynchronous | FileOptions.SequentialScan,
                Share = FileShare.Read,
            });
        return Convert.ToHexString(await SHA256.HashDataAsync(stream, cancellationToken).ConfigureAwait(false));
    }

    private static void Append(IncrementalHash hash, string value)
    {
        Span<byte> length = stackalloc byte[sizeof(int)];
        System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(length, Encoding.UTF8.GetByteCount(value));
        hash.AppendData(length);
        hash.AppendData(Encoding.UTF8.GetBytes(value));
    }

    private static void Append(IncrementalHash hash, ReadOnlySpan<byte> value)
    {
        Span<byte> length = stackalloc byte[sizeof(int)];
        System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(length, value.Length);
        hash.AppendData(length);
        hash.AppendData(value);
    }

    private static bool PathEquals(string left, string right)
    {
        return PathComparer.Equals(Path.GetFullPath(left), Path.GetFullPath(right));
    }

    private static StringComparer PathComparer { get; } =
        OperatingSystem.IsWindows() || OperatingSystem.IsMacOS()
            ? StringComparer.OrdinalIgnoreCase
            : StringComparer.Ordinal;

}
