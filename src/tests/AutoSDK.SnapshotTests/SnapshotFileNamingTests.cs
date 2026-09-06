using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace AutoSDK.SnapshotTests;

/// <summary>
/// Every snapshot path is derived from something else: a file is named after the generated file's
/// hint name, and the directory holding it is named after the spec (`callerName` is
/// <c>Path.GetFileNameWithoutExtension(fileName)</c>). This asserts that each derived name matches
/// its source exactly, case included.
///
/// It guards a failure that cannot reproduce locally on macOS/Windows. When a collision group is
/// renumbered, a generated type can change only in casing (`ToolJsonSchema2` -> `ToolJSONSchema2`).
/// On a case-insensitive filesystem the new name resolves to the file already sitting there, so the
/// write lands inside it and git keeps recording the old spelling — while the generator emits, and
/// CI on Linux looks for, the new one. The same applies to a directory.
/// </summary>
[TestClass]
public sealed class SnapshotFileNamingTests
{
    [TestMethod]
    public void EverySnapshotPathMatchesTheNameItIsDerivedFrom()
    {
        var projectDirectory = GetProjectDirectory();
        var snapshots = Path.Combine(projectDirectory, "Snapshots");
        var specs = Path.GetFullPath(Path.Combine(projectDirectory, "..", "..", "..", "specs"));
        if (!Directory.Exists(snapshots) || !Directory.Exists(specs))
        {
            Assert.Inconclusive($"Expected '{snapshots}' and '{specs}' to exist.");
            return;
        }

        var mismatches = FindFilesNotMatchingTheirHintName(snapshots)
            .Concat(FindDirectoriesNotMatchingTheirSpec(snapshots, specs))
            .OrderBy(x => x, StringComparer.Ordinal);

        // Asserting on the joined report rather than the collection keeps the offenders listed
        // once, instead of the assertion echoing the first of them back after the explanation.
        string.Join(Environment.NewLine, mismatches).Should().BeEmpty(
            "a snapshot stored under a name that differs only in casing reads as a missing file or " +
            "directory on a case-sensitive filesystem, so CI fails on Linux while everything looks " +
            "fine locally. Rename the offenders with `git mv`, which needs two steps via a " +
            "temporary name on a case-insensitive filesystem");
    }

    /// <summary>
    /// A `.verified.cs` baseline is named after the hint name of the file it captures, which the
    /// baseline itself records in its first line.
    /// </summary>
    private static IEnumerable<string> FindFilesNotMatchingTheirHintName(string snapshots)
    {
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
                if (!string.Equals(expected, Path.GetFileName(path), StringComparison.Ordinal))
                {
                    mismatches.Add(
                        $"{Path.GetRelativePath(snapshots, path)}{Environment.NewLine}" +
                        $"    declares HintName: {hintName}{Environment.NewLine}" +
                        $"    so it must be stored as: {expected}");
                }
            });

        return mismatches;
    }

    /// <summary>
    /// A `.verified.txt` baseline is named after its test method, so its own filename carries no
    /// casing to get wrong — but the directory holding it is named after the spec, and can be
    /// mis-cased in exactly the same way a file can.
    ///
    /// A directory that matches a spec only when case is ignored is therefore a real defect; one
    /// that matches no spec at all is named after a test method (`Empty`, `ParallelGeneration`, …)
    /// and is none of this test's business.
    /// </summary>
    private static IEnumerable<string> FindDirectoriesNotMatchingTheirSpec(string snapshots, string specs)
    {
        var specStemsByLowercase = Directory.EnumerateFiles(specs)
            .Select(Path.GetFileNameWithoutExtension)
            .OfType<string>()
            .Distinct(StringComparer.Ordinal)
            .ToLookup(x => x.ToLowerInvariant(), StringComparer.Ordinal);

        // Snapshots/<callerName>/... and Snapshots/CLI/<callerName>/...
        var candidates = Directory.EnumerateDirectories(snapshots)
            .Where(x => !string.Equals(Path.GetFileName(x), "CLI", StringComparison.Ordinal))
            .Concat(Directory.Exists(Path.Combine(snapshots, "CLI"))
                ? Directory.EnumerateDirectories(Path.Combine(snapshots, "CLI"))
                : []);

        foreach (var directory in candidates)
        {
            var name = Path.GetFileName(directory);
            var specStems = specStemsByLowercase[name.ToLowerInvariant()].ToArray();
            if (specStems.Length == 0 || specStems.Contains(name, StringComparer.Ordinal))
            {
                continue;
            }

            yield return
                $"{Path.GetRelativePath(snapshots, directory)}{Environment.NewLine}" +
                $"    matches spec '{specStems[0]}' only when case is ignored";
        }
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
