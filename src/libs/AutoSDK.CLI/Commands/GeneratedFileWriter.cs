using System.Buffers;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace AutoSDK.CLI.Commands;

internal readonly record struct GeneratedOutputFile(string Path, string Text);

internal readonly record struct GeneratedFileWriteDiagnostics(
    TimeSpan Preparation,
    TimeSpan ParallelProcessing,
    TimeSpan NormalizeEncodeHashWorker,
    TimeSpan CompareWorker,
    TimeSpan PhysicalWriteWorker,
    TimeSpan CacheMetadataWorker,
    TimeSpan StaleCleanup);

internal readonly record struct GeneratedFileWriteResult(
    int GeneratedCount,
    int WrittenCount,
    int UnchangedCount,
    int DeletedCount,
    int NormalizedLineCount,
    long GeneratedBytes,
    long WrittenBytes,
    GeneratedFileCacheEntry[] CacheFiles,
    GeneratedFileWriteDiagnostics Diagnostics);

internal static class GeneratedFileWriter
{
    private const int MaxParallelism = 8;
    private static readonly UTF8Encoding Utf8NoBom = new(encoderShouldEmitUTF8Identifier: false);

    public static async Task<GeneratedFileWriteResult> WriteAsync(
        IReadOnlyList<GeneratedOutputFile> files,
        IEnumerable<string> staleCandidates,
        bool deleteStaleFiles,
        IReadOnlyList<GeneratedFileCacheEntry>? cachedFiles = null,
        bool collectDiagnostics = false,
        CancellationToken cancellationToken = default)
    {
        files = files ?? throw new ArgumentNullException(nameof(files));
        staleCandidates = staleCandidates ?? throw new ArgumentNullException(nameof(staleCandidates));
        cachedFiles ??= [];

        var pathComparer = OperatingSystem.IsWindows() || OperatingSystem.IsMacOS()
            ? StringComparer.OrdinalIgnoreCase
            : StringComparer.Ordinal;
        var preparationTime = collectDiagnostics ? Stopwatch.StartNew() : null;
        var expectedPaths = new HashSet<string>(pathComparer);
        var cachedFilesByPath = cachedFiles.ToDictionary(static file => file.Path, pathComparer);
        var writtenCount = 0;
        var unchangedCount = 0;
        var normalizedLineCount = 0;
        long generatedBytes = 0;
        long writtenBytes = 0;
        var pendingFiles = new (string FullPath, string Text)[files.Count];
        var outputCacheFiles = new GeneratedFileCacheEntry[files.Count];

        for (var index = 0; index < files.Count; index++)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var file = files[index];
            var fullPath = Path.GetFullPath(file.Path);
            if (!expectedPaths.Add(fullPath))
            {
                throw new InvalidOperationException($"Multiple generated files target '{fullPath}'.");
            }

            pendingFiles[index] = (fullPath, file.Text);
        }

        foreach (var directory in pendingFiles
                     .Select(static file => Path.GetDirectoryName(file.FullPath))
                     .Where(static directory => !string.IsNullOrEmpty(directory))
                     .Distinct(pathComparer))
        {
            Directory.CreateDirectory(directory!);
        }
        preparationTime?.Stop();

        long normalizeEncodeHashWorkerTicks = 0;
        long compareWorkerTicks = 0;
        long physicalWriteWorkerTicks = 0;
        long cacheMetadataWorkerTicks = 0;

        var parallelProcessingTime = collectDiagnostics ? Stopwatch.StartNew() : null;
        await Parallel.ForAsync(
            0,
            pendingFiles.Length,
            new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, MaxParallelism),
            },
            async (index, itemCancellationToken) =>
            {
                var file = pendingFiles[index];
                var normalizeStart = collectDiagnostics ? Stopwatch.GetTimestamp() : 0;
                var normalizedText = NormalizeTrailingWhitespace(file.Text, out var normalizedLines);
                var byteCount = Utf8NoBom.GetByteCount(normalizedText);
                var encodedContent = ArrayPool<byte>.Shared.Rent(byteCount);
                try
                {
                    var encodedLength = Utf8NoBom.GetBytes(normalizedText.AsSpan(), encodedContent);
                    var content = encodedContent.AsMemory(0, encodedLength);
                    var contentHash = ComputeContentHash(content.Span);
                    if (collectDiagnostics)
                    {
                        Interlocked.Add(
                            ref normalizeEncodeHashWorkerTicks,
                            Stopwatch.GetTimestamp() - normalizeStart);
                    }
                    Interlocked.Add(ref normalizedLineCount, normalizedLines);
                    Interlocked.Add(ref generatedBytes, encodedLength);

                    var compareStart = collectDiagnostics ? Stopwatch.GetTimestamp() : 0;
                    var unchanged = File.Exists(file.FullPath) &&
                        await FileContentsEqualAsync(
                            file.FullPath,
                            content,
                            cachedFilesByPath.GetValueOrDefault(file.FullPath),
                            contentHash,
                            itemCancellationToken).ConfigureAwait(false);
                    if (collectDiagnostics)
                    {
                        Interlocked.Add(
                            ref compareWorkerTicks,
                            Stopwatch.GetTimestamp() - compareStart);
                    }
                    if (unchanged)
                    {
                        Interlocked.Increment(ref unchangedCount);
                    }
                    else
                    {
                        var physicalWriteStart = collectDiagnostics ? Stopwatch.GetTimestamp() : 0;
                        await WriteAtomicallyAsync(
                            file.FullPath,
                            content,
                            itemCancellationToken).ConfigureAwait(false);
                        if (collectDiagnostics)
                        {
                            Interlocked.Add(
                                ref physicalWriteWorkerTicks,
                                Stopwatch.GetTimestamp() - physicalWriteStart);
                        }
                        Interlocked.Increment(ref writtenCount);
                        Interlocked.Add(ref writtenBytes, encodedLength);
                    }

                    var cacheMetadataStart = collectDiagnostics ? Stopwatch.GetTimestamp() : 0;
                    var fileInfo = new FileInfo(file.FullPath);
                    outputCacheFiles[index] = new GeneratedFileCacheEntry(
                        file.FullPath,
                        fileInfo.Length,
                        fileInfo.LastWriteTimeUtc.Ticks,
                        contentHash);
                    if (collectDiagnostics)
                    {
                        Interlocked.Add(
                            ref cacheMetadataWorkerTicks,
                            Stopwatch.GetTimestamp() - cacheMetadataStart);
                    }
                }
                finally
                {
                    ArrayPool<byte>.Shared.Return(encodedContent);
                }
            }).ConfigureAwait(false);
        parallelProcessingTime?.Stop();

        var staleCleanupTime = collectDiagnostics ? Stopwatch.StartNew() : null;
        var deletedCount = 0;
        if (deleteStaleFiles)
        {
            foreach (var candidate in staleCandidates
                         .Select(Path.GetFullPath)
                         .Distinct(pathComparer))
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (expectedPaths.Contains(candidate) || !File.Exists(candidate))
                {
                    continue;
                }

                File.Delete(candidate);
                deletedCount++;
            }
        }
        staleCleanupTime?.Stop();

        return new GeneratedFileWriteResult(
            GeneratedCount: files.Count,
            WrittenCount: writtenCount,
            UnchangedCount: unchangedCount,
            DeletedCount: deletedCount,
            NormalizedLineCount: normalizedLineCount,
            GeneratedBytes: generatedBytes,
            WrittenBytes: writtenBytes,
            CacheFiles: outputCacheFiles,
            Diagnostics: collectDiagnostics ? new GeneratedFileWriteDiagnostics(
                Preparation: preparationTime!.Elapsed,
                ParallelProcessing: parallelProcessingTime!.Elapsed,
                NormalizeEncodeHashWorker: FromStopwatchTicks(normalizeEncodeHashWorkerTicks),
                CompareWorker: FromStopwatchTicks(compareWorkerTicks),
                PhysicalWriteWorker: FromStopwatchTicks(physicalWriteWorkerTicks),
                CacheMetadataWorker: FromStopwatchTicks(cacheMetadataWorkerTicks),
                StaleCleanup: staleCleanupTime!.Elapsed) : default);
    }

    private static TimeSpan FromStopwatchTicks(long ticks)
    {
        return TimeSpan.FromSeconds((double)ticks / Stopwatch.Frequency);
    }

    private static async Task<bool> FileContentsEqualAsync(
        string path,
        ReadOnlyMemory<byte> expectedContent,
        GeneratedFileCacheEntry? cachedFile,
        string expectedHash,
        CancellationToken cancellationToken)
    {
        var fileInfo = new FileInfo(path);
        if (fileInfo.Length != expectedContent.Length)
        {
            return false;
        }

        if (cachedFile is not null &&
            cachedFile.Length == expectedContent.Length &&
            cachedFile.LastWriteTimeUtcTicks == fileInfo.LastWriteTimeUtc.Ticks)
        {
            return string.Equals(
                expectedHash,
                cachedFile.Sha256,
                StringComparison.Ordinal);
        }

        using var stream = new FileStream(
            path,
            new FileStreamOptions
            {
                Access = FileAccess.Read,
                Mode = FileMode.Open,
                Options = FileOptions.Asynchronous | FileOptions.SequentialScan,
                Share = FileShare.Read,
            });
        var comparisonBuffer = ArrayPool<byte>.Shared.Rent(Math.Min(expectedContent.Length, 64 * 1024));
        try
        {
            var comparedLength = 0;
            while (comparedLength < expectedContent.Length)
            {
                var readLength = await stream.ReadAsync(
                    comparisonBuffer.AsMemory(
                        0,
                        Math.Min(comparisonBuffer.Length, expectedContent.Length - comparedLength)),
                    cancellationToken).ConfigureAwait(false);
                if (readLength == 0 ||
                    !comparisonBuffer.AsSpan(0, readLength).SequenceEqual(
                        expectedContent.Span.Slice(comparedLength, readLength)))
                {
                    return false;
                }

                comparedLength += readLength;
            }

            return true;
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(comparisonBuffer);
        }
    }

    private static string ComputeContentHash(ReadOnlySpan<byte> content)
    {
        Span<byte> hash = stackalloc byte[SHA256.HashSizeInBytes];
        SHA256.HashData(content, hash);
        return Convert.ToHexString(hash);
    }

    internal static async Task WriteAtomicallyAsync(
        string path,
        string text,
        CancellationToken cancellationToken = default)
    {
        path = Path.GetFullPath(path);
        var directory = Path.GetDirectoryName(path)
            ?? throw new InvalidOperationException($"Generated output '{path}' has no parent directory.");
        Directory.CreateDirectory(directory);
        cancellationToken.ThrowIfCancellationRequested();

        var byteCount = Utf8NoBom.GetByteCount(text);
        var encodedContent = ArrayPool<byte>.Shared.Rent(byteCount);
        try
        {
            var encodedLength = Utf8NoBom.GetBytes(text.AsSpan(), encodedContent);
            await WriteAtomicallyAsync(
                path,
                encodedContent.AsMemory(0, encodedLength),
                cancellationToken).ConfigureAwait(false);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(encodedContent);
        }
    }

    private static async Task WriteAtomicallyAsync(
        string path,
        ReadOnlyMemory<byte> content,
        CancellationToken cancellationToken)
    {
        path = Path.GetFullPath(path);
        var directory = Path.GetDirectoryName(path)
            ?? throw new InvalidOperationException($"Generated output '{path}' has no parent directory.");
        cancellationToken.ThrowIfCancellationRequested();

        var temporaryPath = Path.Combine(directory, $".autosdk-{Guid.NewGuid():N}.tmp");
        try
        {
            var stream = new FileStream(
                temporaryPath,
                new FileStreamOptions
                {
                    Access = FileAccess.Write,
                    Mode = FileMode.CreateNew,
                    Options = FileOptions.Asynchronous | FileOptions.SequentialScan,
                    Share = FileShare.None,
                });
            try
            {
                await stream.WriteAsync(content, cancellationToken).ConfigureAwait(false);
            }
            finally
            {
                await stream.DisposeAsync().ConfigureAwait(false);
            }
            cancellationToken.ThrowIfCancellationRequested();
            File.Move(temporaryPath, path, overwrite: true);
        }
        finally
        {
            if (File.Exists(temporaryPath))
            {
                File.Delete(temporaryPath);
            }
        }
    }

    internal static string NormalizeTrailingWhitespace(string text, out int normalizedLineCount)
    {
        text = text ?? throw new ArgumentNullException(nameof(text));
        normalizedLineCount = 0;
        var normalizedLength = 0;
        var lineStart = 0;
        for (var index = 0; index <= text.Length; index++)
        {
            if (index != text.Length && text[index] != '\n')
            {
                continue;
            }

            var contentEnd = index;
            var hasCarriageReturn = contentEnd > lineStart && text[contentEnd - 1] == '\r';
            if (hasCarriageReturn)
            {
                contentEnd--;
            }

            var trimmedEnd = contentEnd;
            while (trimmedEnd > lineStart && text[trimmedEnd - 1] is ' ' or '\t')
            {
                trimmedEnd--;
            }

            if (trimmedEnd != contentEnd)
            {
                normalizedLineCount++;
            }

            normalizedLength = checked(normalizedLength + trimmedEnd - lineStart);
            if (hasCarriageReturn)
            {
                normalizedLength++;
            }
            if (index != text.Length)
            {
                normalizedLength++;
            }

            lineStart = index + 1;
        }

        if (normalizedLineCount == 0)
        {
            return text;
        }

        return string.Create(normalizedLength, text, static (destination, source) =>
        {
            var destinationOffset = 0;
            var sourceLineStart = 0;
            for (var index = 0; index <= source.Length; index++)
            {
                if (index != source.Length && source[index] != '\n')
                {
                    continue;
                }

                var contentEnd = index;
                var hasCarriageReturn = contentEnd > sourceLineStart && source[contentEnd - 1] == '\r';
                if (hasCarriageReturn)
                {
                    contentEnd--;
                }

                var trimmedEnd = contentEnd;
                while (trimmedEnd > sourceLineStart && source[trimmedEnd - 1] is ' ' or '\t')
                {
                    trimmedEnd--;
                }

                source.AsSpan(sourceLineStart, trimmedEnd - sourceLineStart)
                    .CopyTo(destination[destinationOffset..]);
                destinationOffset += trimmedEnd - sourceLineStart;
                if (hasCarriageReturn)
                {
                    destination[destinationOffset++] = '\r';
                }
                if (index != source.Length)
                {
                    destination[destinationOffset++] = '\n';
                }

                sourceLineStart = index + 1;
            }
        });
    }
}
