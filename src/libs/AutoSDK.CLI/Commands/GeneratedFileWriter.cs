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
    long WrittenBytes);

internal static class GeneratedFileWriter
{
    private static readonly UTF8Encoding Utf8NoBom = new(encoderShouldEmitUTF8Identifier: false);

    public static async Task<GeneratedFileWriteResult> WriteAsync(
        IReadOnlyList<GeneratedOutputFile> files,
        IEnumerable<string> staleCandidates,
        bool deleteStaleFiles,
        CancellationToken cancellationToken = default)
    {
        files = files ?? throw new ArgumentNullException(nameof(files));
        staleCandidates = staleCandidates ?? throw new ArgumentNullException(nameof(staleCandidates));

        var pathComparer = OperatingSystem.IsWindows() || OperatingSystem.IsMacOS()
            ? StringComparer.OrdinalIgnoreCase
            : StringComparer.Ordinal;
        var expectedPaths = new HashSet<string>(pathComparer);
        var writtenCount = 0;
        var unchangedCount = 0;
        var normalizedLineCount = 0;
        long generatedBytes = 0;
        long writtenBytes = 0;
        var pendingFiles = new (string FullPath, string Text)[files.Count];

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

        await Parallel.ForEachAsync(
            pendingFiles,
            new ParallelOptions
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = Math.Min(Environment.ProcessorCount, 8),
            },
            async (file, itemCancellationToken) =>
            {
                var normalizedText = NormalizeTrailingWhitespace(file.Text, out var normalizedLines);
                var byteCount = Encoding.UTF8.GetByteCount(normalizedText);
                Interlocked.Add(ref normalizedLineCount, normalizedLines);
                Interlocked.Add(ref generatedBytes, byteCount);

                if (File.Exists(file.FullPath) &&
                    await FileContentsEqualAsync(
                        file.FullPath,
                        normalizedText,
                        byteCount,
                        itemCancellationToken).ConfigureAwait(false))
                {
                    Interlocked.Increment(ref unchangedCount);
                    return;
                }

                var directory = Path.GetDirectoryName(file.FullPath);
                if (!string.IsNullOrEmpty(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                await File.WriteAllTextAsync(
                    file.FullPath,
                    normalizedText,
                    Utf8NoBom,
                    itemCancellationToken).ConfigureAwait(false);
                Interlocked.Increment(ref writtenCount);
                Interlocked.Add(ref writtenBytes, byteCount);
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
            WrittenBytes: writtenBytes);
    }

    private static async Task<bool> FileContentsEqualAsync(
        string path,
        string expectedText,
        int expectedByteCount,
        CancellationToken cancellationToken)
    {
        if (new FileInfo(path).Length != expectedByteCount)
        {
            return false;
        }

        return string.Equals(
            await File.ReadAllTextAsync(path, cancellationToken).ConfigureAwait(false),
            expectedText,
            StringComparison.Ordinal);
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
