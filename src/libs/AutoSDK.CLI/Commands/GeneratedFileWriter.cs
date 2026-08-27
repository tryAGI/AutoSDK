using System.Buffers;
using System.Security.Cryptography;
using System.Text;

namespace AutoSDK.CLI.Commands;

internal readonly record struct GeneratedOutputFile(string Path, string Text);

internal readonly record struct GeneratedFileWriteResult(
    int GeneratedCount,
    int WrittenCount,
    int UnchangedCount,
    int DeletedCount,
    int NormalizedLineCount,
    long GeneratedBytes,
    long WrittenBytes,
    GeneratedFileCacheEntry[] CacheFiles);

internal static class GeneratedFileWriter
{
    private const int MaxParallelism = 8;
    private static readonly UTF8Encoding Utf8NoBom = new(encoderShouldEmitUTF8Identifier: false);

    public static async Task<GeneratedFileWriteResult> WriteAsync(
        IReadOnlyList<GeneratedOutputFile> files,
        IEnumerable<string> staleCandidates,
        bool deleteStaleFiles,
        IReadOnlyList<GeneratedFileCacheEntry>? cachedFiles = null,
        CancellationToken cancellationToken = default)
    {
        files = files ?? throw new ArgumentNullException(nameof(files));
        staleCandidates = staleCandidates ?? throw new ArgumentNullException(nameof(staleCandidates));
        cachedFiles ??= [];

        var pathComparer = OperatingSystem.IsWindows() || OperatingSystem.IsMacOS()
            ? StringComparer.OrdinalIgnoreCase
            : StringComparer.Ordinal;
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
                var normalizedText = NormalizeTrailingWhitespace(file.Text, out var normalizedLines);
                var byteCount = Encoding.UTF8.GetByteCount(normalizedText);
                var contentHash = ComputeTextHash(normalizedText, byteCount);
                Interlocked.Add(ref normalizedLineCount, normalizedLines);
                Interlocked.Add(ref generatedBytes, byteCount);

                if (File.Exists(file.FullPath) &&
                    await FileContentsEqualAsync(
                        file.FullPath,
                        normalizedText,
                        byteCount,
                        cachedFilesByPath.GetValueOrDefault(file.FullPath),
                        contentHash,
                        itemCancellationToken).ConfigureAwait(false))
                {
                    Interlocked.Increment(ref unchangedCount);
                }
                else
                {
                    var directory = Path.GetDirectoryName(file.FullPath);
                    if (!string.IsNullOrEmpty(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    await WriteAtomicallyAsync(
                        file.FullPath,
                        normalizedText,
                        itemCancellationToken).ConfigureAwait(false);
                    Interlocked.Increment(ref writtenCount);
                    Interlocked.Add(ref writtenBytes, byteCount);
                }

                var fileInfo = new FileInfo(file.FullPath);
                outputCacheFiles[index] = new GeneratedFileCacheEntry(
                    file.FullPath,
                    fileInfo.Length,
                    fileInfo.LastWriteTimeUtc.Ticks,
                    contentHash);
            }).ConfigureAwait(false);

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

        return new GeneratedFileWriteResult(
            GeneratedCount: files.Count,
            WrittenCount: writtenCount,
            UnchangedCount: unchangedCount,
            DeletedCount: deletedCount,
            NormalizedLineCount: normalizedLineCount,
            GeneratedBytes: generatedBytes,
            WrittenBytes: writtenBytes,
            CacheFiles: outputCacheFiles);
    }

    private static async Task<bool> FileContentsEqualAsync(
        string path,
        string expectedText,
        int expectedByteCount,
        GeneratedFileCacheEntry? cachedFile,
        string expectedHash,
        CancellationToken cancellationToken)
    {
        var fileInfo = new FileInfo(path);
        if (fileInfo.Length != expectedByteCount)
        {
            return false;
        }

        if (cachedFile is not null &&
            cachedFile.Length == expectedByteCount &&
            cachedFile.LastWriteTimeUtcTicks == fileInfo.LastWriteTimeUtc.Ticks)
        {
            return string.Equals(
                expectedHash,
                cachedFile.Sha256,
                StringComparison.Ordinal);
        }

        return string.Equals(
            await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false),
            expectedText,
            StringComparison.Ordinal);
    }

    private static string ComputeTextHash(string text, int byteCount)
    {
        var buffer = ArrayPool<byte>.Shared.Rent(byteCount);
        try
        {
            var written = Utf8NoBom.GetBytes(text.AsSpan(), buffer);
            Span<byte> hash = stackalloc byte[SHA256.HashSizeInBytes];
            SHA256.HashData(buffer.AsSpan(0, written), hash);
            return Convert.ToHexString(hash);
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }
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

        var temporaryPath = Path.Combine(directory, $".autosdk-{Guid.NewGuid():N}.tmp");
        try
        {
            await File.WriteAllTextAsync(
                temporaryPath,
                text,
                Utf8NoBom,
                cancellationToken).ConfigureAwait(false);
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

        if (!ContainsTrailingWhitespace(text))
        {
            return text;
        }

        var builder = new StringBuilder(text.Length);
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

            builder.Append(text.AsSpan(lineStart, trimmedEnd - lineStart));
            if (hasCarriageReturn)
            {
                builder.Append('\r');
            }
            if (index != text.Length)
            {
                builder.Append('\n');
            }

            lineStart = index + 1;
        }

        return builder.ToString();
    }

    private static bool ContainsTrailingWhitespace(string text)
    {
        for (var index = 0; index < text.Length; index++)
        {
            if (text[index] is not (' ' or '\t'))
            {
                continue;
            }

            var next = index + 1;
            while (next < text.Length && text[next] is ' ' or '\t')
            {
                next++;
            }

            if (next == text.Length || text[next] is '\r' or '\n')
            {
                return true;
            }

            index = next - 1;
        }

        return false;
    }
}
