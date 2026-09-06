using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace AutoSDK.SnapshotTests;

/// <summary>
/// Guards the snapshot baselines against a failure that only reproduces on a case-sensitive
/// filesystem, so it passes locally on macOS/Windows and fails in CI on Linux.
///
/// Verify names each baseline after the generated file's hint name. When a collision group is
/// renumbered, a type can change only in casing (`ToolJsonSchema2` -> `ToolJSONSchema2`). On a
/// case-insensitive filesystem the new name resolves to the file already sitting there, so the
/// write lands inside it and git keeps recording the old spelling — while the generator emits,
/// and CI looks for, the new one.
///
/// Every baseline therefore has to be stored under the name its own `//HintName:` header declares.
/// </summary>
[TestClass]
public sealed class SnapshotFileNamingTests
{
    [TestMethod]
    public void EverySnapshotIsStoredUnderTheNameItsHintNameDeclares()
    {
        var snapshots = Path.Combine(GetProjectDirectory(), "Snapshots");
        if (!Directory.Exists(snapshots))
        {
            Assert.Inconclusive($"Snapshots directory was not found at '{snapshots}'.");
            return;
        }

        var mismatches = new ConcurrentBag<string>();
        Parallel.ForEach(
            Directory.EnumerateFiles(snapshots, "*.verified.cs", SearchOption.AllDirectories),
            path =>
            {
                var hintName = ReadHintName(path);
                if (hintName == null)
                {
                    return;
                }

                // "G.Models.Foo.g.cs" is stored as "_#G.Models.Foo.g.verified.cs".
                var expected = "_#" + hintName[..^".cs".Length] + ".verified.cs";
                var actual = Path.GetFileName(path);
                if (!string.Equals(expected, actual, StringComparison.Ordinal))
                {
                    mismatches.Add(
                        $"{Path.GetRelativePath(snapshots, path)}{Environment.NewLine}" +
                        $"    declares HintName: {hintName}{Environment.NewLine}" +
                        $"    so it must be stored as: {expected}");
                }
            });

        mismatches.Should().BeEmpty(
            "every snapshot must be stored under the name its HintName declares, otherwise it " +
            "reads as a missing file on a case-sensitive filesystem. Rename the offenders with " +
            "`git mv` (two steps on a case-insensitive filesystem, via a temporary name):" +
            Environment.NewLine + string.Join(Environment.NewLine, mismatches.OrderBy(x => x, StringComparer.Ordinal)));
    }

    private static string? ReadHintName(string path)
    {
        using var reader = new StreamReader(path, detectEncodingFromByteOrderMarks: true);
        var firstLine = reader.ReadLine();

        const string prefix = "//HintName:";
        if (firstLine == null || !firstLine.StartsWith(prefix, StringComparison.Ordinal))
        {
            return null;
        }

        var hintName = firstLine[prefix.Length..].Trim();

        return hintName.EndsWith(".cs", StringComparison.Ordinal) ? hintName : null;
    }

    private static string GetProjectDirectory([CallerFilePath] string sourceFilePath = "")
    {
        return Path.GetDirectoryName(sourceFilePath) ?? string.Empty;
    }
}
